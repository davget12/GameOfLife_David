namespace GameOfLife
{
    partial class MainWindow
    {
       
        private System.ComponentModel.IContainer components = null;

        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doSomethingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomizeToolStripMenuItemEnterSeed = new System.Windows.Forms.ToolStripMenuItem();
            this.randomizeToolStripMenuItemCurrentSeed = new System.Windows.Forms.ToolStripMenuItem();
            this.randomizeToolStripMenuItemRandomSeed = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherThingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.addColumnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeColumnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.moveDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveRightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveLeftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.OpenToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.SaveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.randomizeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.startToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pauseToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.nextToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.clearToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toggleGridToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.rowsToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.addRowToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.removeRowToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.columnsToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.addColumnToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.removeColumnToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.moveLeftToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.moveUpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.moveDownToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.moveRightToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.DimensionsStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.SeedStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.IntervalStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.GenerationStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.CellCountStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.graphicsPanelContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.changeColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cellsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showHideGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomizeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.enterSeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentSeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomSeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.graphicsPanel = new GameOfLife.GraphicsPanel();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.graphicsPanelContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.doSomethingToolStripMenuItem,
            this.otherThingToolStripMenuItem});
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.Name = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator7,
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = global::GameOfLife.Properties.Resources.New;
            resources.ApplyResources(this.newToolStripMenuItem, "newToolStripMenuItem");
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::GameOfLife.Properties.Resources.Save;
            resources.ApplyResources(this.saveToolStripMenuItem, "saveToolStripMenuItem");
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            resources.ApplyResources(this.toolStripSeparator7, "toolStripSeparator7");
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::GameOfLife.Properties.Resources.Open;
            resources.ApplyResources(this.openToolStripMenuItem, "openToolStripMenuItem");
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.toolWindowToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            resources.ApplyResources(this.toolsToolStripMenuItem, "toolsToolStripMenuItem");
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            resources.ApplyResources(this.resetToolStripMenuItem, "resetToolStripMenuItem");
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // doSomethingToolStripMenuItem
            // 
            this.doSomethingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.randomizeToolStripMenuItem,
            this.startToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.nextToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.toggleGridToolStripMenuItem});
            this.doSomethingToolStripMenuItem.Name = "doSomethingToolStripMenuItem";
            resources.ApplyResources(this.doSomethingToolStripMenuItem, "doSomethingToolStripMenuItem");
            // 
            // randomizeToolStripMenuItem
            // 
            this.randomizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.randomizeToolStripMenuItemEnterSeed,
            this.randomizeToolStripMenuItemCurrentSeed,
            this.randomizeToolStripMenuItemRandomSeed});
            this.randomizeToolStripMenuItem.Image = global::GameOfLife.Properties.Resources.Random;
            this.randomizeToolStripMenuItem.Name = "randomizeToolStripMenuItem";
            resources.ApplyResources(this.randomizeToolStripMenuItem, "randomizeToolStripMenuItem");
            // 
            // randomizeToolStripMenuItemEnterSeed
            // 
            this.randomizeToolStripMenuItemEnterSeed.Image = global::GameOfLife.Properties.Resources.Random;
            this.randomizeToolStripMenuItemEnterSeed.Name = "randomizeToolStripMenuItemEnterSeed";
            resources.ApplyResources(this.randomizeToolStripMenuItemEnterSeed, "randomizeToolStripMenuItemEnterSeed");
            this.randomizeToolStripMenuItemEnterSeed.Click += new System.EventHandler(this.enterSeedToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            resources.ApplyResources(this.optionsToolStripMenuItem, "optionsToolStripMenuItem");
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // randomizeToolStripMenuItemCurrentSeed
            // 
            this.randomizeToolStripMenuItemCurrentSeed.Image = global::GameOfLife.Properties.Resources.Random;
            this.randomizeToolStripMenuItemCurrentSeed.Name = "randomizeToolStripMenuItemCurrentSeed";
            resources.ApplyResources(this.randomizeToolStripMenuItemCurrentSeed, "randomizeToolStripMenuItemCurrentSeed");
            this.randomizeToolStripMenuItemCurrentSeed.Click += new System.EventHandler(this.currentSeedToolStripMenuItem_Click);
            // 
            // randomizeToolStripMenuItemRandomSeed
            // 
            this.randomizeToolStripMenuItemRandomSeed.Image = global::GameOfLife.Properties.Resources.Random;
            this.randomizeToolStripMenuItemRandomSeed.Name = "randomizeToolStripMenuItemRandomSeed";
            resources.ApplyResources(this.randomizeToolStripMenuItemRandomSeed, "randomizeToolStripMenuItemRandomSeed");
            this.randomizeToolStripMenuItemRandomSeed.Click += new System.EventHandler(this.randomizeToolStripMenuItem_Click);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Image = global::GameOfLife.Properties.Resources.Play;
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            resources.ApplyResources(this.startToolStripMenuItem, "startToolStripMenuItem");
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem1
            // 
            resources.ApplyResources(this.optionsToolStripMenuItem1, "optionsToolStripMenuItem1");
            this.optionsToolStripMenuItem1.Name = "optionsToolStripMenuItem1";
            this.optionsToolStripMenuItem1.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);

            // 
            // pauseToolStripMenuItem
            // 
            resources.ApplyResources(this.pauseToolStripMenuItem, "pauseToolStripMenuItem");
            this.pauseToolStripMenuItem.Image = global::GameOfLife.Properties.Resources.Pause;
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // nextToolStripMenuItem
            // 
            this.nextToolStripMenuItem.Image = global::GameOfLife.Properties.Resources.Next;
            this.nextToolStripMenuItem.Name = "nextToolStripMenuItem";
            resources.ApplyResources(this.nextToolStripMenuItem, "nextToolStripMenuItem");
            this.nextToolStripMenuItem.Click += new System.EventHandler(this.nextToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Image = global::GameOfLife.Properties.Resources.Clear;
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            resources.ApplyResources(this.clearToolStripMenuItem, "clearToolStripMenuItem");
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // toggleGridToolStripMenuItem
            // 
            this.toggleGridToolStripMenuItem.Image = global::GameOfLife.Properties.Resources.Grid;
            this.toggleGridToolStripMenuItem.Name = "toggleGridToolStripMenuItem";
            resources.ApplyResources(this.toggleGridToolStripMenuItem, "toggleGridToolStripMenuItem");
            this.toggleGridToolStripMenuItem.Click += new System.EventHandler(this.toggleGridToolStripMenuItem_Click);
            // 
            // otherThingToolStripMenuItem
            // 
            this.otherThingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRowToolStripMenuItem,
            this.removeRowToolStripMenuItem,
            this.toolStripSeparator3,
            this.addColumnToolStripMenuItem,
            this.removeColumnToolStripMenuItem,
            this.toolStripSeparator5,
            this.moveDownToolStripMenuItem,
            this.moveUpToolStripMenuItem,
            this.moveRightToolStripMenuItem,
            this.moveLeftToolStripMenuItem});
            this.otherThingToolStripMenuItem.Name = "otherThingToolStripMenuItem";
            resources.ApplyResources(this.otherThingToolStripMenuItem, "otherThingToolStripMenuItem");
            // 
            // addRowToolStripMenuItem
            // 
            this.addRowToolStripMenuItem.Image = global::GameOfLife.Properties.Resources.Add;
            this.addRowToolStripMenuItem.Name = "addRowToolStripMenuItem";
            resources.ApplyResources(this.addRowToolStripMenuItem, "addRowToolStripMenuItem");
            this.addRowToolStripMenuItem.Click += new System.EventHandler(this.addRowToolStripMenuItem_Click);
            // 
            // removeRowToolStripMenuItem
            // 
            this.removeRowToolStripMenuItem.Image = global::GameOfLife.Properties.Resources.Remove;
            this.removeRowToolStripMenuItem.Name = "removeRowToolStripMenuItem";
            resources.ApplyResources(this.removeRowToolStripMenuItem, "removeRowToolStripMenuItem");
            this.removeRowToolStripMenuItem.Click += new System.EventHandler(this.removeRowToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // addColumnToolStripMenuItem
            // 
            this.addColumnToolStripMenuItem.Image = global::GameOfLife.Properties.Resources.Add;
            this.addColumnToolStripMenuItem.Name = "addColumnToolStripMenuItem";
            resources.ApplyResources(this.addColumnToolStripMenuItem, "addColumnToolStripMenuItem");
            this.addColumnToolStripMenuItem.Click += new System.EventHandler(this.addColumnToolStripMenuItem_Click);
            // 
            // removeColumnToolStripMenuItem
            // 
            this.removeColumnToolStripMenuItem.Image = global::GameOfLife.Properties.Resources.Remove;
            this.removeColumnToolStripMenuItem.Name = "removeColumnToolStripMenuItem";
            resources.ApplyResources(this.removeColumnToolStripMenuItem, "removeColumnToolStripMenuItem");
            this.removeColumnToolStripMenuItem.Click += new System.EventHandler(this.removeColumnToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            // 
            // moveDownToolStripMenuItem
            // 
            this.moveDownToolStripMenuItem.Image = global::GameOfLife.Properties.Resources.Down;
            this.moveDownToolStripMenuItem.Name = "moveDownToolStripMenuItem";
            resources.ApplyResources(this.moveDownToolStripMenuItem, "moveDownToolStripMenuItem");
            this.moveDownToolStripMenuItem.Click += new System.EventHandler(this.moveDownToolStripMenuItem_Click);
            // 
            // moveUpToolStripMenuItem
            // 
            this.moveUpToolStripMenuItem.Image = global::GameOfLife.Properties.Resources.Up;
            this.moveUpToolStripMenuItem.Name = "moveUpToolStripMenuItem";
            resources.ApplyResources(this.moveUpToolStripMenuItem, "moveUpToolStripMenuItem");
            this.moveUpToolStripMenuItem.Click += new System.EventHandler(this.moveUpToolStripMenuItem_Click);
            // 
            // moveRightToolStripMenuItem
            // 
            this.moveRightToolStripMenuItem.Image = global::GameOfLife.Properties.Resources.Right;
            this.moveRightToolStripMenuItem.Name = "moveRightToolStripMenuItem";
            resources.ApplyResources(this.moveRightToolStripMenuItem, "moveRightToolStripMenuItem");
            this.moveRightToolStripMenuItem.Click += new System.EventHandler(this.moveRightToolStripMenuItem_Click);
            // 
            // moveLeftToolStripMenuItem
            // 
            this.moveLeftToolStripMenuItem.Image = global::GameOfLife.Properties.Resources.Left;
            this.moveLeftToolStripMenuItem.Name = "moveLeftToolStripMenuItem";
            resources.ApplyResources(this.moveLeftToolStripMenuItem, "moveLeftToolStripMenuItem");
            this.moveLeftToolStripMenuItem.Click += new System.EventHandler(this.moveLeftToolStripMenuItem_Click);
      
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripButton,
            this.SaveToolStripButton,
            this.toolStripSeparator8,
            this.randomizeToolStripButton,
            this.startToolStripButton,
            this.pauseToolStripButton,
            this.nextToolStripButton,
            this.clearToolStripButton,
            this.toggleGridToolStripButton,
            this.toolStripSeparator1,
            this.rowsToolStripLabel,
            this.addRowToolStripButton,
            this.removeRowToolStripButton,
            this.toolStripSeparator2,
            this.columnsToolStripLabel,
            this.addColumnToolStripButton,
            this.removeColumnToolStripButton,
            this.toolStripSeparator6,
            this.moveLeftToolStripButton,
            this.moveUpToolStripButton,
            this.moveDownToolStripButton,
            this.moveRightToolStripButton});
            resources.ApplyResources(this.toolStrip, "toolStrip");
            this.toolStrip.Name = "toolStrip";
            // 
            // OpenToolStripButton
            // 
            this.OpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenToolStripButton.Image = global::GameOfLife.Properties.Resources.Open;
            resources.ApplyResources(this.OpenToolStripButton, "OpenToolStripButton");
            this.OpenToolStripButton.Name = "OpenToolStripButton";
            this.OpenToolStripButton.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // SaveToolStripButton
            // 
            this.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveToolStripButton.Image = global::GameOfLife.Properties.Resources.Save;
            resources.ApplyResources(this.SaveToolStripButton, "SaveToolStripButton");
            this.SaveToolStripButton.Name = "SaveToolStripButton";
            this.SaveToolStripButton.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            resources.ApplyResources(this.toolStripSeparator8, "toolStripSeparator8");
            // 
            // randomizeToolStripButton
            // 
            this.randomizeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.randomizeToolStripButton.Image = global::GameOfLife.Properties.Resources.Random;
            resources.ApplyResources(this.randomizeToolStripButton, "randomizeToolStripButton");
            this.randomizeToolStripButton.Name = "randomizeToolStripButton";
            this.randomizeToolStripButton.Click += new System.EventHandler(this.randomizeToolStripMenuItem_Click);
            // 
            // startToolStripButton
            // 
            this.startToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.startToolStripButton.Image = global::GameOfLife.Properties.Resources.Play;
            resources.ApplyResources(this.startToolStripButton, "startToolStripButton");
            this.startToolStripButton.Name = "startToolStripButton";
            this.startToolStripButton.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // pauseToolStripButton
            // 
            this.pauseToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.pauseToolStripButton, "pauseToolStripButton");
            this.pauseToolStripButton.Image = global::GameOfLife.Properties.Resources.Pause;
            this.pauseToolStripButton.Name = "pauseToolStripButton";
            this.pauseToolStripButton.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // nextToolStripButton
            // 
            this.nextToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nextToolStripButton.Image = global::GameOfLife.Properties.Resources.Next;
            resources.ApplyResources(this.nextToolStripButton, "nextToolStripButton");
            this.nextToolStripButton.Name = "nextToolStripButton";
            this.nextToolStripButton.Click += new System.EventHandler(this.nextToolStripMenuItem_Click);
            // 
            // clearToolStripButton
            // 
            this.clearToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clearToolStripButton.Image = global::GameOfLife.Properties.Resources.Clear;
            resources.ApplyResources(this.clearToolStripButton, "clearToolStripButton");
            this.clearToolStripButton.Name = "clearToolStripButton";
            this.clearToolStripButton.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // toggleGridToolStripButton
            // 
            this.toggleGridToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toggleGridToolStripButton.Image = global::GameOfLife.Properties.Resources.Grid;
            resources.ApplyResources(this.toggleGridToolStripButton, "toggleGridToolStripButton");
            this.toggleGridToolStripButton.Name = "toggleGridToolStripButton";
            this.toggleGridToolStripButton.Click += new System.EventHandler(this.toggleGridToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // rowsToolStripLabel
            // 
            this.rowsToolStripLabel.Name = "rowsToolStripLabel";
            resources.ApplyResources(this.rowsToolStripLabel, "rowsToolStripLabel");
            // 
            // addRowToolStripButton
            // 
            this.addRowToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addRowToolStripButton.Image = global::GameOfLife.Properties.Resources.Add;
            resources.ApplyResources(this.addRowToolStripButton, "addRowToolStripButton");
            this.addRowToolStripButton.Name = "addRowToolStripButton";
            this.addRowToolStripButton.Click += new System.EventHandler(this.addRowToolStripButton_Click);
            // 
            // removeRowToolStripButton
            // 
            this.removeRowToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.removeRowToolStripButton.Image = global::GameOfLife.Properties.Resources.Remove;
            resources.ApplyResources(this.removeRowToolStripButton, "removeRowToolStripButton");
            this.removeRowToolStripButton.Name = "removeRowToolStripButton";
            this.removeRowToolStripButton.Click += new System.EventHandler(this.removeRowToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // columnsToolStripLabel
            // 
            this.columnsToolStripLabel.Name = "columnsToolStripLabel";
            resources.ApplyResources(this.columnsToolStripLabel, "columnsToolStripLabel");
            // 
            // addColumnToolStripButton
            // 
            this.addColumnToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addColumnToolStripButton.Image = global::GameOfLife.Properties.Resources.Add;
            resources.ApplyResources(this.addColumnToolStripButton, "addColumnToolStripButton");
            this.addColumnToolStripButton.Name = "addColumnToolStripButton";
            this.addColumnToolStripButton.Click += new System.EventHandler(this.addColumnToolStripButton_Click);
            // 
            // removeColumnToolStripButton
            // 
            this.removeColumnToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.removeColumnToolStripButton.Image = global::GameOfLife.Properties.Resources.Remove;
            resources.ApplyResources(this.removeColumnToolStripButton, "removeColumnToolStripButton");
            this.removeColumnToolStripButton.Name = "removeColumnToolStripButton";
            this.removeColumnToolStripButton.Click += new System.EventHandler(this.removeColumnToolStripButton_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            resources.ApplyResources(this.toolStripSeparator6, "toolStripSeparator6");
            // 
            // moveLeftToolStripButton
            // 
            this.moveLeftToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.moveLeftToolStripButton.Image = global::GameOfLife.Properties.Resources.Left;
            resources.ApplyResources(this.moveLeftToolStripButton, "moveLeftToolStripButton");
            this.moveLeftToolStripButton.Name = "moveLeftToolStripButton";
            this.moveLeftToolStripButton.Click += new System.EventHandler(this.moveLeftToolStripButton_Click);
            // 
            // moveUpToolStripButton
            // 
            this.moveUpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.moveUpToolStripButton.Image = global::GameOfLife.Properties.Resources.Up;
            resources.ApplyResources(this.moveUpToolStripButton, "moveUpToolStripButton");
            this.moveUpToolStripButton.Name = "moveUpToolStripButton";
            this.moveUpToolStripButton.Click += new System.EventHandler(this.moveUpToolStripButton_Click);
            // 
            // moveDownToolStripButton
            // 
            this.moveDownToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.moveDownToolStripButton.Image = global::GameOfLife.Properties.Resources.Down;
            resources.ApplyResources(this.moveDownToolStripButton, "moveDownToolStripButton");
            this.moveDownToolStripButton.Name = "moveDownToolStripButton";
            this.moveDownToolStripButton.Click += new System.EventHandler(this.moveDownToolStripButton_Click);
            // 
            // moveRightToolStripButton
            // 
            this.moveRightToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.moveRightToolStripButton.Image = global::GameOfLife.Properties.Resources.Right;
            resources.ApplyResources(this.moveRightToolStripButton, "moveRightToolStripButton");
            this.moveRightToolStripButton.Name = "moveRightToolStripButton";
            this.moveRightToolStripButton.Click += new System.EventHandler(this.moveRightToolStripButton_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.SystemColors.Control;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DimensionsStatusLabel,
            this.SeedStatusLabel,
            this.IntervalStatusLabel,
            this.GenerationStatusLabel,
            this.CellCountStatusLabel});
            resources.ApplyResources(this.statusStrip, "statusStrip");
            this.statusStrip.Name = "statusStrip";
            // 
            // DimensionsStatusLabel
            // 
            this.DimensionsStatusLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DimensionsStatusLabel.Name = "DimensionsStatusLabel";
            this.DimensionsStatusLabel.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            resources.ApplyResources(this.DimensionsStatusLabel, "DimensionsStatusLabel");
            // 
            // SeedStatusLabel
            // 
            this.SeedStatusLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SeedStatusLabel.Name = "SeedStatusLabel";
            this.SeedStatusLabel.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            resources.ApplyResources(this.SeedStatusLabel, "SeedStatusLabel");
            // 
            // IntervalStatusLabel
            // 
            this.IntervalStatusLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IntervalStatusLabel.Name = "IntervalStatusLabel";
            this.IntervalStatusLabel.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            resources.ApplyResources(this.IntervalStatusLabel, "IntervalStatusLabel");
            // 
            // GenerationStatusLabel
            // 
            this.GenerationStatusLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GenerationStatusLabel.Name = "GenerationStatusLabel";
            this.GenerationStatusLabel.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            resources.ApplyResources(this.GenerationStatusLabel, "GenerationStatusLabel");
            // 
            // CellCountStatusLabel
            // 
            this.CellCountStatusLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CellCountStatusLabel.Name = "CellCountStatusLabel";
            this.CellCountStatusLabel.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            resources.ApplyResources(this.CellCountStatusLabel, "CellCountStatusLabel");
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // graphicsPanelContextMenu
            // 
            this.graphicsPanelContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeColorToolStripMenuItem,
            this.showHideGridToolStripMenuItem,
            this.randomizeToolStripMenuItem1,
            this.optionsToolStripMenuItem1});
            this.graphicsPanelContextMenu.Name = "graphicsPanel1ContextMenu";
            resources.ApplyResources(this.graphicsPanelContextMenu, "graphicsPanelContextMenu");
            // 
            // changeColorToolStripMenuItem
            // 
            this.changeColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backgroundToolStripMenuItem,
            this.gridToolStripMenuItem,
            this.cellsToolStripMenuItem});
            this.changeColorToolStripMenuItem.Name = "changeColorToolStripMenuItem";
            resources.ApplyResources(this.changeColorToolStripMenuItem, "changeColorToolStripMenuItem");
            // 
            // backgroundToolStripMenuItem
            // 
            this.backgroundToolStripMenuItem.Name = "backgroundToolStripMenuItem";
            resources.ApplyResources(this.backgroundToolStripMenuItem, "backgroundToolStripMenuItem");
            this.backgroundToolStripMenuItem.Click += new System.EventHandler(this.backgroundToolStripMenuItem_Click);
            // 
            // gridToolStripMenuItem
            // 
            this.gridToolStripMenuItem.Name = "gridToolStripMenuItem";
            resources.ApplyResources(this.gridToolStripMenuItem, "gridToolStripMenuItem");
            this.gridToolStripMenuItem.Click += new System.EventHandler(this.gridToolStripMenuItem_Click);
            // 
            // cellsToolStripMenuItem
            // 
            this.cellsToolStripMenuItem.Name = "cellsToolStripMenuItem";
            resources.ApplyResources(this.cellsToolStripMenuItem, "cellsToolStripMenuItem");
            this.cellsToolStripMenuItem.Click += new System.EventHandler(this.cellsToolStripMenuItem_Click);
            // 
            // showHideGridToolStripMenuItem
            // 
            this.showHideGridToolStripMenuItem.Image = global::GameOfLife.Properties.Resources.Grid;
            this.showHideGridToolStripMenuItem.Name = "showHideGridToolStripMenuItem";
            resources.ApplyResources(this.showHideGridToolStripMenuItem, "showHideGridToolStripMenuItem");
            this.showHideGridToolStripMenuItem.Click += new System.EventHandler(this.toggleGridToolStripMenuItem_Click);
            // 
            // randomizeToolStripMenuItem1
            // 
            this.randomizeToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enterSeedToolStripMenuItem,
            this.currentSeedToolStripMenuItem,
            this.randomSeedToolStripMenuItem});
            this.randomizeToolStripMenuItem1.Image = global::GameOfLife.Properties.Resources.Random;
            this.randomizeToolStripMenuItem1.Name = "randomizeToolStripMenuItem1";
            resources.ApplyResources(this.randomizeToolStripMenuItem1, "randomizeToolStripMenuItem1");
            // 
            // enterSeedToolStripMenuItem
            // 
            this.enterSeedToolStripMenuItem.Image = global::GameOfLife.Properties.Resources.Random;
            this.enterSeedToolStripMenuItem.Name = "enterSeedToolStripMenuItem";
            resources.ApplyResources(this.enterSeedToolStripMenuItem, "enterSeedToolStripMenuItem");
            this.enterSeedToolStripMenuItem.Click += new System.EventHandler(this.enterSeedToolStripMenuItem_Click);
            // 
            // currentSeedToolStripMenuItem
            // 
            this.currentSeedToolStripMenuItem.Image = global::GameOfLife.Properties.Resources.Random;
            this.currentSeedToolStripMenuItem.Name = "currentSeedToolStripMenuItem";
            resources.ApplyResources(this.currentSeedToolStripMenuItem, "currentSeedToolStripMenuItem");
            this.currentSeedToolStripMenuItem.Click += new System.EventHandler(this.currentSeedToolStripMenuItem_Click);
            // 
            // randomSeedToolStripMenuItem
            // 
            this.randomSeedToolStripMenuItem.Image = global::GameOfLife.Properties.Resources.Random;
            this.randomSeedToolStripMenuItem.Name = "randomSeedToolStripMenuItem";
            resources.ApplyResources(this.randomSeedToolStripMenuItem, "randomSeedToolStripMenuItem");
            this.randomSeedToolStripMenuItem.Click += new System.EventHandler(this.randomizeToolStripMenuItem_Click);
            // 
            // graphicsPanel
            // 
            this.graphicsPanel.BackColor = System.Drawing.Color.White;
            this.graphicsPanel.ContextMenuStrip = this.graphicsPanelContextMenu;
            resources.ApplyResources(this.graphicsPanel, "graphicsPanel");
            this.graphicsPanel.Name = "graphicsPanel";
            this.graphicsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.graphicsPanel_Paint);
            this.graphicsPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.graphicsPanel_MouseDown);
            // 
            // MainWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.graphicsPanel);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainWindow";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.graphicsPanelContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private GraphicsPanel graphicsPanel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doSomethingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nextToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton clearToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toggleGridToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton randomizeToolStripButton;
        private System.Windows.Forms.ToolStripButton startToolStripButton;
        private System.Windows.Forms.ToolStripButton pauseToolStripButton;
        private System.Windows.Forms.ToolStripButton nextToolStripButton;
        private System.Windows.Forms.ToolStripButton toggleGridToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem otherThingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addColumnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeColumnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeRowToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel rowsToolStripLabel;
        private System.Windows.Forms.ToolStripButton addRowToolStripButton;
        private System.Windows.Forms.ToolStripButton removeRowToolStripButton;
        private System.Windows.Forms.ToolStripLabel columnsToolStripLabel;
        private System.Windows.Forms.ToolStripButton addColumnToolStripButton;
        private System.Windows.Forms.ToolStripButton removeColumnToolStripButton;
        private System.Windows.Forms.ToolStripStatusLabel GenerationStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem moveUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveDownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveLeftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveRightToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton moveUpToolStripButton;
        private System.Windows.Forms.ToolStripButton moveDownToolStripButton;
        private System.Windows.Forms.ToolStripButton moveLeftToolStripButton;
        private System.Windows.Forms.ToolStripButton moveRightToolStripButton;
        private System.Windows.Forms.ToolStripStatusLabel DimensionsStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel SeedStatusLabel;
        private System.Windows.Forms.ContextMenuStrip graphicsPanelContextMenu;
        private System.Windows.Forms.ToolStripMenuItem changeColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cellsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showHideGridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomizeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem currentSeedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomSeedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enterSeedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomizeToolStripMenuItemRandomSeed;
        private System.Windows.Forms.ToolStripMenuItem randomizeToolStripMenuItemEnterSeed;
        private System.Windows.Forms.ToolStripMenuItem randomizeToolStripMenuItemCurrentSeed;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripStatusLabel CellCountStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel IntervalStatusLabel;
        private System.Windows.Forms.ToolStripButton OpenToolStripButton;
        private System.Windows.Forms.ToolStripButton SaveToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem toolWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

