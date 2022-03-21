

using System;
using System.Drawing;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class OptionsDialog : Form
    {
        public event EventHandler Apply;

        public OptionsDialog()
        {
            InitializeComponent();

            PreviewGraphicsPanel.Invalidate();
        }

        #region << Properties >>

        public bool Finite
        {
          
            set
            {
                if (value)
                    radioButtonFinite.Checked = true;
               
            }
        }

       
        public int NumberOfRows
        {
            get
            {
                return (int)numericUpDownRows.Value;
            }
            set
            {
                if ((decimal)value >= numericUpDownRows.Maximum)
                {
                    numericUpDownRows.Value = numericUpDownRows.Maximum;
                }
                else if ((decimal)value <= numericUpDownRows.Minimum)
                {
                    numericUpDownRows.Value = numericUpDownRows.Minimum;
                }
                else
                {
                    numericUpDownRows.Value = (decimal)value;
                }
            }
        }
        
        public int NumberOfColumns
        {
            get
            {
                return (int)numericUpDownColumns.Value;
            }
            set
            {
                if ((decimal)value >= numericUpDownColumns.Maximum)
                {
                    numericUpDownColumns.Value = numericUpDownColumns.Maximum;
                }
                else if ((decimal)value <= numericUpDownColumns.Minimum)
                {
                    numericUpDownColumns.Value = numericUpDownColumns.Minimum;
                }
                else
                {
                    numericUpDownColumns.Value = (decimal)value;
                }
            }
        }
       
        public int Interval
        {
            get
            {
                return (int)numericUpDownInterval.Value;
            }
            set
            {
                if ((decimal)value >= numericUpDownInterval.Maximum)
                {
                    numericUpDownInterval.Value = numericUpDownInterval.Maximum;
                }
                else if ((decimal)value <= numericUpDownInterval.Minimum)
                {
                    numericUpDownInterval.Value = numericUpDownInterval.Minimum;
                }
                else
                {
                    numericUpDownInterval.Value = (decimal)value;
                }
            }
        }
       
        public Color Background
        {
            get
            {
                return buttonBackgroundColor.BackColor;
            }
            set
            {
                buttonBackgroundColor.BackColor = value;
                buttonBackgroundColor.ForeColor = Color.FromArgb(~(value.ToArgb()));
            }
        }
        
        public Color GridColor
        {
            get
            {
                return buttonGridColor.BackColor;
            }
            set
            {
                buttonGridColor.BackColor = value;
                buttonGridColor.ForeColor = Color.FromArgb(~(value.ToArgb()));
            }
        }
        
        public Color CellsColor
        {
            get
            {
                return buttonCellColor.BackColor;
            }
            set
            {
                buttonCellColor.BackColor = value;
                buttonCellColor.ForeColor = Color.FromArgb(~(value.ToArgb()));
            }
        }
       
        public bool ShowGrid
        {
            get
            {
                return checkBoxShowGrid.Checked;
            }
            set
            {
                checkBoxShowGrid.Checked = value;
            }
        }
       
        public int LineWidth
        {
            get
            {
                return (int)numericUpDownLineWidth.Value;
            }
            set
            {
                if ((decimal)value >= numericUpDownLineWidth.Maximum)
                {
                    numericUpDownLineWidth.Value = numericUpDownLineWidth.Maximum;
                }
                else if ((decimal)value <= numericUpDownLineWidth.Minimum)
                {
                    numericUpDownLineWidth.Value = numericUpDownLineWidth.Minimum;
                }
                else
                {
                    numericUpDownLineWidth.Value = (decimal)value;
                }
            }
        }
        #endregion

        #region << Events >>
       
        private void buttonBackgroundColor_Click(object sender, EventArgs e)
        {
            
            ColorDialog dlg = new ColorDialog();

          
            dlg.Color = buttonBackgroundColor.BackColor;

           
            if (DialogResult.OK == dlg.ShowDialog())
            {
                
                buttonBackgroundColor.BackColor = dlg.Color;

                
                buttonBackgroundColor.ForeColor = Color.FromArgb(~(dlg.Color.ToArgb()));

               
                PreviewGraphicsPanel.Invalidate();
            }
        }
        
        private void buttonGridColor_Click(object sender, EventArgs e)
        {
            
            ColorDialog dlg = new ColorDialog();

            
            dlg.Color = buttonGridColor.BackColor;

            
            if (DialogResult.OK == dlg.ShowDialog())
            {
               
                buttonGridColor.BackColor = dlg.Color;

               
                buttonGridColor.ForeColor = Color.FromArgb(~(dlg.Color.ToArgb()));

               
                PreviewGraphicsPanel.Invalidate();
            }
        }
      
        private void buttonCellColor_Click(object sender, EventArgs e)
        {
           
            ColorDialog dlg = new ColorDialog();

            
            dlg.Color = buttonCellColor.BackColor;

           
            if (DialogResult.OK == dlg.ShowDialog())
            {
               
                buttonCellColor.BackColor = dlg.Color;

               
                buttonCellColor.ForeColor = Color.FromArgb(~(dlg.Color.ToArgb()));

               
                PreviewGraphicsPanel.Invalidate();
            }
        }
       
        private void defaultsButton_Click(object sender, EventArgs e)
        {
            
            Finite = false;
            
            NumberOfRows = 25;
            
            NumberOfColumns = 25;
           
            Interval = 1;
            
            Background = Color.Wheat;
           
            GridColor = Color.Red;
            
            CellsColor = Color.Navy;
            
            ShowGrid = true;
           
            LineWidth = -2;

            
            PreviewGraphicsPanel.Invalidate();
        }
      
        private void applyButton_Click(object sender, EventArgs e)
        {
            if (Apply != null)
                Apply(this, EventArgs.Empty);
        }
        
        private void checkBoxShowGrid_CheckedChanged(object sender, EventArgs e)
        {
            PreviewGraphicsPanel.Invalidate();
        }
      
        private void numericUpDownLineWidth_ValueChanged(object sender, EventArgs e)
        {
            PreviewGraphicsPanel.Invalidate();
        }
       
        private void PreviewGraphicsPanel_Paint(object sender, PaintEventArgs e)
        {
            

            float panelWidth = PreviewGraphicsPanel.Width;
            float panelHeight = PreviewGraphicsPanel.Height;
            float cellWidth = panelWidth / 4.0f;
            float cellHeight = panelHeight / 4.0f;

            Graphics g = e.Graphics;

            
            Brush cellBrush = new SolidBrush(CellsColor);

            
            PreviewGraphicsPanel.BackColor = Background;

            int x, y = 0;

          
            if (LineWidth < 0)
            {
                
                if (ShowGrid)
                {
                   
                    Pen gridPen = new Pen(GridColor, -LineWidth);

                    for (x = 0; x <= 4; ++x)
                        g.DrawLine(gridPen, x * cellWidth, 0.0f, x * cellWidth, panelHeight);
                    for (; y <= 4; ++y)
                        g.DrawLine(gridPen, 0.0f, y * cellHeight, panelWidth, y * cellHeight);
                }

                
                x = 2; y = 0;
                g.FillRectangle(cellBrush, x * cellWidth, y++ * cellHeight, cellWidth, cellHeight);
                g.FillRectangle(cellBrush, x-- * cellWidth, y * cellHeight, cellWidth, cellHeight);
                g.FillRectangle(cellBrush, x * cellWidth, y++ * cellHeight, cellWidth, cellHeight);
                g.FillRectangle(cellBrush, x * cellWidth, y++ * cellHeight, cellWidth, cellHeight);
                g.FillRectangle(cellBrush, x-- * cellWidth, y * cellHeight, cellWidth, cellHeight);
                g.FillRectangle(cellBrush, x * cellWidth, y * cellHeight, cellWidth, cellHeight);

            }
           
            else
            {
                
                x = 2;
                g.FillRectangle(cellBrush, x * cellWidth, y++ * cellHeight, cellWidth, cellHeight);
                g.FillRectangle(cellBrush, x-- * cellWidth, y * cellHeight, cellWidth, cellHeight);
                g.FillRectangle(cellBrush, x * cellWidth, y++ * cellHeight, cellWidth, cellHeight);
                g.FillRectangle(cellBrush, x * cellWidth, y++ * cellHeight, cellWidth, cellHeight);
                g.FillRectangle(cellBrush, x-- * cellWidth, y * cellHeight, cellWidth, cellHeight);
                g.FillRectangle(cellBrush, x * cellWidth, y * cellHeight, cellWidth, cellHeight);

               
                if (ShowGrid && 0 != LineWidth)
                {
                   
                    Pen gridPen = new Pen(GridColor, LineWidth);

                    for (; x <= 4; ++x)
                        g.DrawLine(gridPen, x * cellWidth, 0.0f, x * cellWidth, panelHeight);
                    for (y = 0; y <= 4; ++y)
                        g.DrawLine(gridPen, 0.0f, y * cellHeight, panelWidth, y * cellHeight);
                }
            }
        }
        #endregion
    }
}

