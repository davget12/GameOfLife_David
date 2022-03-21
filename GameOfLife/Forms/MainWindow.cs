

using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace GameOfLife
{
    public partial class MainWindow : Form
    {
        #region << Fields >>

        int numRows;
        
        int numCols;
        
        int cellCount;
        
        int generation;
        
        int randomizeSeed;
        
        int gridWidth;
       
        bool[,] cells;

      


        bool showGrid;
       
        Color backgroundColor;
        
        Color cellColor;
      
        Color gridColor;
        
        Brush cellBrush;
       
        Pen gridPen;
       
        Timer timer;
       
        Random rnd;
        
        


        #endregion
        #region << Events >>


        
        private void graphicsPanel_Paint(object sender, PaintEventArgs e)
        {
            
            cellCount = 0;

           
            if (gridWidth < 0)
               
                DrawCellsOverGrid(e.Graphics);

          
            else
                
                DrawGridOverCells(e.Graphics);

            
            UpdateStatusBar();
        }
        
        private void graphicsPanel_MouseDown(object sender, MouseEventArgs e)
        {
           
            if (MouseButtons.Right != e.Button)
            {
               
                float cellWidth = (float)graphicsPanel.ClientSize.Width / numCols;
                float cellHeight = (float)graphicsPanel.ClientSize.Height / numRows;

               
                int x = (int)(e.X / cellWidth);
                int y = (int)(e.Y / cellHeight);

               
                if (x < numCols && y < numRows)
                {
                    
                    cells[x, y] = !cells[x, y];

                    
                    graphicsPanel.Invalidate();
                }
            }
        }
        
        void timer_Tick(object sender, EventArgs e)
        {
           
            NextGen();
        }

        
       
       
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            SaveFileDialog dlg = new SaveFileDialog();

            
            dlg.Filter = "Text File" + "|*.txt|"
                        + "All Files" + "|*.*";
            dlg.FilterIndex = 1;
            dlg.DefaultExt = "txt";

           
            if (DialogResult.OK == dlg.ShowDialog())
            {
                StreamWriter writer = new StreamWriter(dlg.FileName);

                int y = 0, x;
               
                for (; y < numRows; ++y)
                {
                    for (x = 0; x < numCols; ++x)
                        
                        writer.Write(cells[x, y] ? 'O' : '.');
                    writer.Write('\n');
                }

                writer.Close();
            }
        }
        
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Filter = "Text File" + "|*.txt|"
                        + "Life Lexicon Plaintext File" + "|*.cells|"
                        + "All Supported Files" + " (*.txt, *.cells)|*.txt;*.cells|"
                        + "All Files" + "|*.*";
            dlg.FilterIndex = 3;

            
            if (DialogResult.OK == dlg.ShowDialog())
            {
                
                ResetUniverse();

                
                int universeWidth = 0;
                int universeHeight = 0;

                
                string s;

               
                StreamReader reader;

                
                string filename = dlg.FileName;

                
                reader = new StreamReader(filename);

               
                while (true)
                {
                    s = reader.ReadLine();
                    if (null == s) 
                        break;
                    if (0 == s.Length) 
                        continue;
                    if ('!' != s[0]) 
                    {
                        universeWidth = (s.Length > universeWidth) ? s.Length : universeWidth;
                        ++universeHeight;
                    }
                }
                reader.Close();

                
                if (0 < universeHeight && 0 < universeWidth)
                {
                    
                    bool isCells = IsCells(filename);

                    
                    int startX, startY;

                    
                    if (isCells)
                    {
                        
                        numCols = (numCols > (15 + universeWidth)) ? numCols : (15 + universeWidth);
                        numRows = (numRows > (15 + universeHeight)) ? numRows : (15 + universeHeight);

                       
                        startX = (numCols >> 1) - (universeWidth >> 1);
                        startY = (numRows >> 1) - (universeHeight >> 1);

                        
                        if (startX < 0) startX = 0;
                        if (startY < 0) startY = 0;
                    }
                    
                    else
                    {
                        
                        numCols = universeWidth;
                        numRows = universeHeight;

                        
                        startX = 0;
                        startY = 0;
                    }

                   
                    cells = new bool[numCols, numRows];

                    
                    reader = new StreamReader(filename);

                    
                    int x, y = 0;
                    while (true)
                    {
                        
                        s = reader.ReadLine();
                       
                        if (null == s)
                            break;
                        
                        if (0 == s.Length)
                            continue;
                        
                        if ('!' != s[0])
                        {
                            
                            for (x = 0; x < universeWidth; ++x)
                            {
                               
                                if (s.Length <= x)
                                    break;

                               
                                if ('O' != s[x] && '.' != s[x])
                                    continue;

                                
                                cells[x + startX, y + startY] = 'O' == s[x];
                            }
                            
                            ++y;
                        }
                    }

                    reader.Close();

                   
                    graphicsPanel.Invalidate();
                }
            }
        }

        
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            ResetUniverse();
        }
        
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            ResetUniverse();
        }
        
        private void nextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            NextGen();
        }
        
        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            EnableSimulation();
        }
        
        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            DisableSimulation();
        }

        
        private void toggleGridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            showGrid = !showGrid;

            
            showHideGridToolStripMenuItem.Text = showGrid ? "Hide &Grid" : "Show &Grid";

            
            graphicsPanel.Invalidate();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            DisableSimulation();

            
            OptionsDialog dlg = new OptionsDialog();

            
            
            dlg.NumberOfColumns = numCols;
            dlg.NumberOfRows = numRows;
            dlg.Interval = timer.Interval;
            dlg.Background = backgroundColor;
            dlg.GridColor = gridColor;
            dlg.CellsColor = cellColor;
            dlg.ShowGrid = showGrid;
            dlg.LineWidth = gridWidth;

            
            dlg.Apply += OptionsDlg_Apply;

            
            if (DialogResult.OK == dlg.ShowDialog())
            {
                
               
                numCols = dlg.NumberOfColumns;
                numRows = dlg.NumberOfRows;
                timer.Interval = dlg.Interval;
                backgroundColor = dlg.Background;
                gridColor = dlg.GridColor;
                cellColor = dlg.CellsColor;
                showGrid = dlg.ShowGrid;
                gridWidth = dlg.LineWidth;

               
                ResizeUniverse();

               
                UpdateColors();
            }
        }
       
        private void OptionsDlg_Apply(object sender, EventArgs e)
        {
           
            OptionsDialog dlg = (OptionsDialog)sender;

           
           
            numCols = dlg.NumberOfColumns;
            numRows = dlg.NumberOfRows;
            timer.Interval = dlg.Interval;
            backgroundColor = dlg.Background;
            gridColor = dlg.GridColor;
            cellColor = dlg.CellsColor;
            showGrid = dlg.ShowGrid;
            gridWidth = dlg.LineWidth;

            
            ResizeUniverse();

            
            UpdateColors();
        }




        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            Properties.Settings.Default.BackgroundColor = backgroundColor;
            Properties.Settings.Default.CellColor = cellColor;
            Properties.Settings.Default.GridColor = gridColor;
            Properties.Settings.Default.LineWidth = gridWidth;
            Properties.Settings.Default.NumCols = numCols;
            Properties.Settings.Default.NumRows = numRows;
            Properties.Settings.Default.TimerInterval = timer.Interval;
            Properties.Settings.Default.ShowGrid = showGrid;
            Properties.Settings.Default.RandomSeed = randomizeSeed;

           
            Properties.Settings.Default.Save();
        }
        
        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Properties.Settings.Default.Reset();

            
            backgroundColor = Properties.Settings.Default.BackgroundColor;
            cellColor = Properties.Settings.Default.CellColor;
            gridColor = Properties.Settings.Default.GridColor;
            gridWidth = Properties.Settings.Default.LineWidth;
            numCols = Properties.Settings.Default.NumCols;
            numRows = Properties.Settings.Default.NumRows;
            timer.Interval = Properties.Settings.Default.TimerInterval;
            showGrid = Properties.Settings.Default.ShowGrid;
            randomizeSeed = Properties.Settings.Default.RandomSeed;

            
            Reseed(randomizeSeed);
            UpdateColors();
            ResetUniverse();
        }


        


       
        private void backgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            ColorDialog dlg = new ColorDialog();

            
            dlg.Color = backgroundColor;

            
            if (DialogResult.OK == dlg.ShowDialog())
            {
                
                backgroundColor = dlg.Color;

                
                UpdateColors();
            }
        }
        
        private void gridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            ColorDialog dlg = new ColorDialog();

            
            dlg.Color = gridColor;

            
            if (DialogResult.OK == dlg.ShowDialog())
            {
                
                gridColor = dlg.Color;

                
                UpdateColors();
            }
        }
        
        private void cellsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            ColorDialog dlg = new ColorDialog();

            
            dlg.Color = cellColor;

            
            if (DialogResult.OK == dlg.ShowDialog())
            {
               
                cellColor = dlg.Color;

                
                UpdateColors();
            }
        }


        
        private void randomizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            RandomizeCells(new Random((int)DateTime.Now.Ticks).Next());
        }
        
        private void enterSeedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            SeedDialog dlg = new SeedDialog();

            
            dlg.Seed = randomizeSeed;

            
            if (DialogResult.OK == dlg.ShowDialog())
                
                RandomizeCells(dlg.Seed);
        }
        
        private void currentSeedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RandomizeCells(randomizeSeed);
        }


        
        private void addColumnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            addColumn();
        }
        
        private void removeColumnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            removeColumn();
        }
        
        private void addRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            addRow();
        }
        
        private void removeRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            removeRow();
        }

        
        
        private void addColumnToolStripButton_Click(object sender, EventArgs e)
        {
            
            addColumn();
        }
        
        private void removeColumnToolStripButton_Click(object sender, EventArgs e)
        {
            
            removeColumn();
        }
        
        private void addRowToolStripButton_Click(object sender, EventArgs e)
        {
            
            addRow();
        }
       
        private void removeRowToolStripButton_Click(object sender, EventArgs e)
        {
            
            removeRow();
        }


        
        private void moveUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            translateUp();
        }
        
        private void moveDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            translateDown();
        }
        
        private void moveLeftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            translateLeft();
        }
        
        private void moveRightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            translateRight();
        }

       
        private void moveUpToolStripButton_Click(object sender, EventArgs e)
        {
            
            translateUp();
        }
        
        private void moveDownToolStripButton_Click(object sender, EventArgs e)
        {
            
            translateDown();
        }
        
        private void moveLeftToolStripButton_Click(object sender, EventArgs e)
        {
            
            translateLeft();
        }
        
        private void moveRightToolStripButton_Click(object sender, EventArgs e)
        {
            
            translateRight();
        }


        #endregion
        #region << Methods >>


        
        private void UpdateColors()
        {
            
            cellBrush = new SolidBrush(cellColor);

            
            gridPen = new Pen(gridColor, 0 < gridWidth ? gridWidth : -gridWidth);

            
            graphicsPanel.BackColor = backgroundColor;

            
            backgroundToolStripMenuItem.BackColor = backgroundColor;
            cellsToolStripMenuItem.BackColor = cellColor;
            gridToolStripMenuItem.BackColor = gridColor;

            
            backgroundToolStripMenuItem.ForeColor = Color.FromArgb(~(backgroundColor.ToArgb()));
            cellsToolStripMenuItem.ForeColor = Color.FromArgb(~(cellColor.ToArgb()));
            gridToolStripMenuItem.ForeColor = Color.FromArgb(~(gridColor.ToArgb()));

            
            graphicsPanel.Invalidate();
        }
        
        private void UpdateStatusBar()
        {
           
            GenerationStatusLabel.Text = "Generation: " + generation;
            DimensionsStatusLabel.Text = "Universe: " + numCols + "×" + numRows
                                            +  " (Finite)";
            SeedStatusLabel.Text = 0 == randomizeSeed ? "Seed: Zero" : ("Seed: " + randomizeSeed);
            CellCountStatusLabel.Text = "Living Cells: " + cellCount;
            IntervalStatusLabel.Text = "Time Interval: " + timer.Interval + " ms";
        }


        
        private void NextGen()
        {
            
            ++generation;

            
            bool[,] nextGen = new bool[numCols, numRows];


            int xLen = cells.GetLength(0);
            int yLen = cells.GetLength(1);
            int numNeighbors;
            for (int y = 0; y < yLen; ++y)
            {
                for (int x = 0; x < xLen; ++x)
                {
                    numNeighbors = GetNumNeighborsFinite(x, y);

                    if (cells[x, y])
                    {
                        if (numNeighbors == 2 || numNeighbors == 3)
                        {
                            nextGen[x, y] = true;
                        }
                        else
                        {
                            nextGen[x, y] = false;
                            --cellCount;
                        }

                    }
                    else
                    {
                        if (numNeighbors == 3)
                        {
                            nextGen[x, y] = true;
                            ++cellCount;
                        }
                        else
                        {
                            nextGen[x, y] = false;
                        }
                    }
                }
            }


            cells = nextGen;

            
            graphicsPanel.Invalidate();
        }
       
        
        private void RandomizeCells(int _seed)
        {
            
            Reseed(_seed);

            
            DisableSimulation();
            generation = 0;

            int x = 0, y;
            for (; x < numCols; ++x)
                for (y = 0; y < numRows; ++y)
                   
                    cells[x, y] = 0 == rnd.Next(3);

            
            graphicsPanel.Invalidate();
        }
        
        
        private void Reseed(int _seed)
        {
            randomizeSeed = _seed;
            rnd = new Random(randomizeSeed);
            UpdateStatusBar();
        }
        
        private void ResetUniverse()
        {
            
            DisableSimulation();

            
            generation = 0;

            
            cells = new bool[numCols, numRows];

            
            graphicsPanel.Invalidate();
        }


        
       
        private int GetNumNeighborsFinite(int x, int y)
        {
            
            int x_minus = x - 1; 
            int y_minus = y - 1; 
            int x_plus = x + 1; 
            int y_plus = y + 1; 

            
            int neighbors = 0;

            
            if (0 <= y_minus)
            {
                if (0 <= x_minus) if (cells[x_minus, y_minus]) ++neighbors; 
                if (x_plus < numCols) if (cells[x_plus, y_minus]) ++neighbors; 
                if (cells[x, y_minus]) ++neighbors;
            }

            
            if (0 <= x_minus) if (cells[x_minus, y]) ++neighbors; 
            if (x_plus < numCols) if (cells[x_plus, y]) ++neighbors; 

            
            if (y_plus < numRows)
            {
                if (0 <= x_minus) if (cells[x_minus, y_plus]) ++neighbors; 
                if (x_plus < numCols) if (cells[x_plus, y_plus]) ++neighbors; 
                if (cells[x, y_plus]) ++neighbors; 
            }

            return neighbors;
        }
        
       


        
        private void addColumn()
        {
            ++numCols;
            ResizeUniverse();
        }
        
        private void addRow()
        {
            ++numRows;
            ResizeUniverse();
        }
       
        private void removeColumn()
        {
            if (1 < numCols) --numCols; 
            ResizeUniverse();
        }
       
        private void removeRow()
        {
            if (1 < numRows) --numRows; 
            ResizeUniverse();
        }
        
        private void ResizeUniverse()
        {
            
            bool[,] newCells = new bool[numCols, numRows];

            int x = 0, y;
            
            for (; x < numCols && x < cells.GetLength(0); ++x)
                for (y = 0; y < numRows && y < cells.GetLength(1); ++y)
                    newCells[x, y] = cells[x, y];

           
            cells = newCells;

            if (numCols <= 1)
            {
                removeColumnToolStripButton.Enabled = false;
                removeColumnToolStripMenuItem.Enabled = false;
            }
            else if (!removeColumnToolStripButton.Enabled)
            {
                removeColumnToolStripButton.Enabled = true;
                removeColumnToolStripMenuItem.Enabled = true;
            }
            if (numRows <= 1)
            {
                removeRowToolStripButton.Enabled = false;
                removeRowToolStripMenuItem.Enabled = false;
            }
            else if (!removeRowToolStripButton.Enabled)
            {
                removeRowToolStripButton.Enabled = true;
                removeRowToolStripMenuItem.Enabled = true;
            }

            
            graphicsPanel.Invalidate();
        }


        
        private void translateDown()
        {
            
            bool[,] newCells = new bool[numCols, numRows];

            int x = 0, y = 1;

           

           
            for (; y < numRows; ++y)
                for (x = 0; x < numCols; ++x)
                    newCells[x, y] = cells[x, y - 1];

            
            cells = newCells;

            
            graphicsPanel.Invalidate();
        }
      
        private void translateUp()
        {
           
            bool[,] newCells = new bool[numCols, numRows];

            int x = 0, y = 0;

           
            

           
            for (; y < numRows - 1; ++y)
                for (x = 0; x < numCols; ++x)
                    newCells[x, y] = cells[x, y + 1];

            
            cells = newCells;

            
            graphicsPanel.Invalidate();
        }
        
        private void translateRight()
        {
            
            bool[,] newCells = new bool[numCols, numRows];

            int x = 1, y = 0;

            
            

            
            for (; x < numCols; ++x)
                for (y = 0; y < numRows; ++y)
                    newCells[x, y] = cells[x - 1, y];

            
            cells = newCells;

            
            graphicsPanel.Invalidate();
        }
        
        private void translateLeft()
        {
            
            bool[,] newCells = new bool[numCols, numRows];

            int x = 0, y = 0;

            
            

            
            for (; x < numCols - 1; ++x)
                for (y = 0; y < numRows; ++y)
                    newCells[x, y] = cells[x + 1, y];

            
            cells = newCells;

            
            graphicsPanel.Invalidate();
        }


       
       


        
        private void DisableSimulation()
        {
            
            timer.Enabled = false;

           
            startToolStripButton.Enabled = true;
            startToolStripMenuItem.Enabled = true;

           
            pauseToolStripButton.Enabled = false;
            pauseToolStripMenuItem.Enabled = false;
        }
       
        private void EnableSimulation()
        {
            
            timer.Enabled = true;

            
            startToolStripButton.Enabled = false;
            startToolStripMenuItem.Enabled = false;

            
            pauseToolStripButton.Enabled = true;
            pauseToolStripMenuItem.Enabled = true;
        }


        
        private void DrawCellsOverGrid(Graphics g)
        {
            
            float cellWidth = (float)graphicsPanel.ClientSize.Width / numCols;
            float cellHeight = (float)graphicsPanel.ClientSize.Height / numRows;

            
            if (showGrid) DrawGrid(g, cellWidth, cellHeight);

            
            int x = 0, y;
            for (; x < numCols; ++x)
                for (y = 0; y < numRows; ++y)
                    if (cells[x, y])
                    {
                        
                        g.FillRectangle(cellBrush, x * cellWidth, y * cellHeight, cellWidth, cellHeight);

                       
                        ++cellCount;
                    }
        }
        
        private void DrawGridOverCells(Graphics g)
        {
            
            float cellWidth = (float)graphicsPanel.ClientSize.Width / numCols;
            float cellHeight = (float)graphicsPanel.ClientSize.Height / numRows;

            
            int x = 0, y;
            for (; x < numCols; ++x)
                for (y = 0; y < numRows; ++y)
                    if (cells[x, y])
                    {
                        
                        g.FillRectangle(cellBrush, x * cellWidth, y * cellHeight, cellWidth, cellHeight);

                        
                        ++cellCount;
                    }

           
            if (showGrid && 0 != gridWidth) DrawGrid(g, cellWidth, cellHeight);
        }
        
       
        private void DrawGrid(Graphics g, float columnWidth, float rowHeight)
        {
            float panelWidth = graphicsPanel.Width;
            float panelHeight = graphicsPanel.Height;

            
            for (int c = 0; c <= numCols; ++c)
                g.DrawLine(gridPen, c * columnWidth, 0.0f, c * columnWidth, panelHeight);

            
            for (int r = 0; r <= numRows; ++r)
                g.DrawLine(gridPen, 0.0f, r * rowHeight, panelWidth, r * rowHeight);
        }

        
        static private bool IsCells(string _filename)
        {
            int filenameLength = _filename.Length;
            if (6 < filenameLength)
                if (('.' == _filename[filenameLength - 6]) &&
                    ('c' == _filename[filenameLength - 5] || 'C' == _filename[filenameLength - 5]) &&
                    ('e' == _filename[filenameLength - 4] || 'E' == _filename[filenameLength - 4]) &&
                    ('l' == _filename[filenameLength - 3] || 'L' == _filename[filenameLength - 3]) &&
                    ('l' == _filename[filenameLength - 2] || 'L' == _filename[filenameLength - 2]) &&
                    ('s' == _filename[filenameLength - 1] || 'S' == _filename[filenameLength - 1]))
                    return true;
            return false;
        }

        
        


        #endregion

       
        public MainWindow()
        {
            InitializeComponent();

            
            numRows = Properties.Settings.Default.NumRows;
            numCols = Properties.Settings.Default.NumCols;
            cells = new bool[numCols, numRows];

            
            randomizeSeed = Properties.Settings.Default.RandomSeed;
            rnd = new Random(randomizeSeed);

            
            timer = new Timer();
            timer.Interval = Properties.Settings.Default.TimerInterval;
            DisableSimulation();
            timer.Tick += timer_Tick;

            
            backgroundColor = Properties.Settings.Default.BackgroundColor; 
            cellColor = Properties.Settings.Default.CellColor; 
            gridColor = Properties.Settings.Default.GridColor; 

            gridWidth = Properties.Settings.Default.LineWidth; 
            showGrid = Properties.Settings.Default.ShowGrid; 
            showHideGridToolStripMenuItem.Text = showGrid ? "Hide &Grid" : "Show &Grid";

            
            

            cellCount = 0; 
            generation = 0; 
            ResizeUniverse();
            UpdateColors();
            UpdateStatusBar();
        }
    }
}

