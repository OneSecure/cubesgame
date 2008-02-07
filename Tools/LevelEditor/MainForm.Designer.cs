namespace LevelEditor
{
  partial class MainForm
  {
    /// <summary>
    /// Designer variable used to keep track of non-visual components.
    /// </summary>
    private System.ComponentModel.IContainer components = null;
    
    /// <summary>
    /// Disposes resources used by the form.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing) {
        if (components != null) {
          components.Dispose();
        }
      }
      base.Dispose(disposing);
    }
    
    /// <summary>
    /// This method is required for Windows Forms designer support.
    /// Do not change the method contents inside the source code editor. The Forms designer might
    /// not be able to load this method if it was changed manually.
    /// </summary>
    private void InitializeComponent()
    {
    	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
    	this.menuStrip1 = new System.Windows.Forms.MenuStrip();
    	this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
    	this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
    	this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
    	this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
    	this.importBMPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
    	this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
    	this.levelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
    	this.chooseLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
    	this.toolStrip1 = new System.Windows.Forms.ToolStrip();
    	this.toolStripButtonNormalField = new System.Windows.Forms.ToolStripButton();
    	this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
    	this.toolStripButtonStartField = new System.Windows.Forms.ToolStripButton();
    	this.toolStripButtonFinishField = new System.Windows.Forms.ToolStripButton();
    	this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
    	this.toolStripButtonMask = new System.Windows.Forms.ToolStripButton();
    	this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
    	this.prevLevelButton = new System.Windows.Forms.ToolStripButton();
    	this.nextLevelButton = new System.Windows.Forms.ToolStripButton();
    	this.statusStrip1 = new System.Windows.Forms.StatusStrip();
    	this.statusBarTextLabel = new System.Windows.Forms.ToolStripStatusLabel();
    	this.levelView = new System.Windows.Forms.Panel();
    	this.trackBar1 = new System.Windows.Forms.TrackBar();
    	this.toolProp = new System.Windows.Forms.ToolStrip();
    	this.maskToolProp = new System.Windows.Forms.ToolStripLabel();
    	this.normalFieldProp = new System.Windows.Forms.ToolStripLabel();
    	this.startFieldProp = new System.Windows.Forms.ToolStripLabel();
    	this.finishFieldProp = new System.Windows.Forms.ToolStripLabel();
    	this.menuStrip1.SuspendLayout();
    	this.toolStrip1.SuspendLayout();
    	this.statusStrip1.SuspendLayout();
    	this.levelView.SuspendLayout();
    	((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
    	this.SuspendLayout();
    	// 
    	// menuStrip1
    	// 
    	this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
    	this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
    	    	    	this.fileToolStripMenuItem,
    	    	    	this.levelToolStripMenuItem});
    	this.menuStrip1.Location = new System.Drawing.Point(0, 0);
    	this.menuStrip1.Name = "menuStrip1";
    	this.menuStrip1.Size = new System.Drawing.Size(484, 24);
    	this.menuStrip1.TabIndex = 0;
    	this.menuStrip1.Text = "menuStrip1";
    	// 
    	// fileToolStripMenuItem
    	// 
    	this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
    	    	    	this.openToolStripMenuItem,
    	    	    	this.saveToolStripMenuItem,
    	    	    	this.saveAsToolStripMenuItem,
    	    	    	this.importBMPToolStripMenuItem,
    	    	    	this.exitToolStripMenuItem});
    	this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
    	this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
    	this.fileToolStripMenuItem.Text = "File";
    	// 
    	// openToolStripMenuItem
    	// 
    	this.openToolStripMenuItem.Name = "openToolStripMenuItem";
    	this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
    	this.openToolStripMenuItem.Text = "Open...";
    	this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItemClick);
    	// 
    	// saveToolStripMenuItem
    	// 
    	this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
    	this.saveToolStripMenuItem.ShortcutKeyDisplayString = "Strg+S";
    	this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
    	this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
    	this.saveToolStripMenuItem.Text = "Save";
    	this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItemClick);
    	// 
    	// saveAsToolStripMenuItem
    	// 
    	this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
    	this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
    	this.saveAsToolStripMenuItem.Text = "Save As...";
    	this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItemClick);
    	// 
    	// importBMPToolStripMenuItem
    	// 
    	this.importBMPToolStripMenuItem.Name = "importBMPToolStripMenuItem";
    	this.importBMPToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
    	this.importBMPToolStripMenuItem.Text = "Import BMP...";
    	this.importBMPToolStripMenuItem.Click += new System.EventHandler(this.ImportBMPToolStripMenuItemClick);
    	// 
    	// exitToolStripMenuItem
    	// 
    	this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
    	this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
    	this.exitToolStripMenuItem.Text = "Exit";
    	this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
    	// 
    	// levelToolStripMenuItem
    	// 
    	this.levelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
    	    	    	this.chooseLevelToolStripMenuItem});
    	this.levelToolStripMenuItem.Name = "levelToolStripMenuItem";
    	this.levelToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
    	this.levelToolStripMenuItem.Text = "Level";
    	// 
    	// chooseLevelToolStripMenuItem
    	// 
    	this.chooseLevelToolStripMenuItem.Name = "chooseLevelToolStripMenuItem";
    	this.chooseLevelToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
    	this.chooseLevelToolStripMenuItem.Text = "Choose Level...";
    	this.chooseLevelToolStripMenuItem.Click += new System.EventHandler(this.ChooseLevelToolStripMenuItemClick);
    	// 
    	// toolStrip1
    	// 
    	this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
    	this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
    	this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
    	    	    	this.toolStripButtonNormalField,
    	    	    	this.toolStripSeparator2,
    	    	    	this.toolStripButtonStartField,
    	    	    	this.toolStripButtonFinishField,
    	    	    	this.toolStripSeparator3,
    	    	    	this.toolStripButtonMask,
    	    	    	this.toolStripSeparator1,
    	    	    	this.prevLevelButton,
    	    	    	this.nextLevelButton});
    	this.toolStrip1.Location = new System.Drawing.Point(0, 24);
    	this.toolStrip1.Name = "toolStrip1";
    	this.toolStrip1.Size = new System.Drawing.Size(484, 25);
    	this.toolStrip1.TabIndex = 1;
    	this.toolStrip1.Text = "toolStrip1";
    	// 
    	// toolStripButtonNormalField
    	// 
    	this.toolStripButtonNormalField.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
    	this.toolStripButtonNormalField.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNormalField.Image")));
    	this.toolStripButtonNormalField.ImageTransparentColor = System.Drawing.Color.Magenta;
    	this.toolStripButtonNormalField.Name = "toolStripButtonNormalField";
    	this.toolStripButtonNormalField.Size = new System.Drawing.Size(23, 22);
    	this.toolStripButtonNormalField.Tag = 0;
    	this.toolStripButtonNormalField.Text = "Normal Fields";
    	this.toolStripButtonNormalField.Click += new System.EventHandler(this.toolChanged);
    	// 
    	// toolStripSeparator2
    	// 
    	this.toolStripSeparator2.Name = "toolStripSeparator2";
    	this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
    	// 
    	// toolStripButtonStartField
    	// 
    	this.toolStripButtonStartField.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
    	this.toolStripButtonStartField.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonStartField.Image")));
    	this.toolStripButtonStartField.ImageTransparentColor = System.Drawing.Color.Magenta;
    	this.toolStripButtonStartField.Name = "toolStripButtonStartField";
    	this.toolStripButtonStartField.Size = new System.Drawing.Size(23, 22);
    	this.toolStripButtonStartField.Tag = 1;
    	this.toolStripButtonStartField.Text = "Starting Field";
    	this.toolStripButtonStartField.Click += new System.EventHandler(this.toolChanged);
    	// 
    	// toolStripButtonFinishField
    	// 
    	this.toolStripButtonFinishField.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
    	this.toolStripButtonFinishField.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFinishField.Image")));
    	this.toolStripButtonFinishField.ImageTransparentColor = System.Drawing.Color.Magenta;
    	this.toolStripButtonFinishField.Name = "toolStripButtonFinishField";
    	this.toolStripButtonFinishField.Size = new System.Drawing.Size(23, 22);
    	this.toolStripButtonFinishField.Tag = 2;
    	this.toolStripButtonFinishField.Text = "Finish Fields";
    	this.toolStripButtonFinishField.Click += new System.EventHandler(this.toolChanged);
    	// 
    	// toolStripSeparator3
    	// 
    	this.toolStripSeparator3.Name = "toolStripSeparator3";
    	this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
    	// 
    	// toolStripButtonMask
    	// 
    	this.toolStripButtonMask.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
    	this.toolStripButtonMask.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonMask.Image")));
    	this.toolStripButtonMask.ImageTransparentColor = System.Drawing.Color.Magenta;
    	this.toolStripButtonMask.Name = "toolStripButtonMask";
    	this.toolStripButtonMask.Size = new System.Drawing.Size(23, 22);
    	this.toolStripButtonMask.Tag = 254;
    	this.toolStripButtonMask.Text = "Mask Tool";
    	this.toolStripButtonMask.Click += new System.EventHandler(this.toolChanged);
    	// 
    	// toolStripSeparator1
    	// 
    	this.toolStripSeparator1.Name = "toolStripSeparator1";
    	this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
    	// 
    	// prevLevelButton
    	// 
    	this.prevLevelButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
    	this.prevLevelButton.Image = ((System.Drawing.Image)(resources.GetObject("prevLevelButton.Image")));
    	this.prevLevelButton.ImageTransparentColor = System.Drawing.Color.Magenta;
    	this.prevLevelButton.Name = "prevLevelButton";
    	this.prevLevelButton.Size = new System.Drawing.Size(23, 22);
    	this.prevLevelButton.Text = "Previous Level";
    	this.prevLevelButton.Click += new System.EventHandler(this.PrevLevelButtonClick);
    	// 
    	// nextLevelButton
    	// 
    	this.nextLevelButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
    	this.nextLevelButton.Image = ((System.Drawing.Image)(resources.GetObject("nextLevelButton.Image")));
    	this.nextLevelButton.ImageTransparentColor = System.Drawing.Color.Magenta;
    	this.nextLevelButton.Name = "nextLevelButton";
    	this.nextLevelButton.Size = new System.Drawing.Size(23, 22);
    	this.nextLevelButton.Text = "Next Level";
    	this.nextLevelButton.Click += new System.EventHandler(this.NextLevelButtonClick);
    	// 
    	// statusStrip1
    	// 
    	this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
    	    	    	this.statusBarTextLabel});
    	this.statusStrip1.Location = new System.Drawing.Point(0, 342);
    	this.statusStrip1.Name = "statusStrip1";
    	this.statusStrip1.Size = new System.Drawing.Size(484, 22);
    	this.statusStrip1.TabIndex = 2;
    	this.statusStrip1.Text = "statusStrip1";
    	// 
    	// statusBarTextLabel
    	// 
    	this.statusBarTextLabel.Name = "statusBarTextLabel";
    	this.statusBarTextLabel.Size = new System.Drawing.Size(0, 17);
    	// 
    	// levelView
    	// 
    	this.levelView.BackColor = System.Drawing.Color.Black;
    	this.levelView.Controls.Add(this.trackBar1);
    	this.levelView.Cursor = System.Windows.Forms.Cursors.Hand;
    	this.levelView.Dock = System.Windows.Forms.DockStyle.Fill;
    	this.levelView.Location = new System.Drawing.Point(0, 74);
    	this.levelView.Name = "levelView";
    	this.levelView.Size = new System.Drawing.Size(484, 268);
    	this.levelView.TabIndex = 3;
    	this.levelView.Paint += new System.Windows.Forms.PaintEventHandler(this.LevelViewPaint);
    	this.levelView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LevelViewMouseDown);
    	// 
    	// trackBar1
    	// 
    	this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
    	this.trackBar1.Location = new System.Drawing.Point(377, 245);
    	this.trackBar1.Maximum = 60;
    	this.trackBar1.Minimum = 15;
    	this.trackBar1.Name = "trackBar1";
    	this.trackBar1.Size = new System.Drawing.Size(107, 45);
    	this.trackBar1.TabIndex = 4;
    	this.trackBar1.TickFrequency = 5;
    	this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
    	this.trackBar1.Value = 20;
    	this.trackBar1.ValueChanged += new System.EventHandler(this.TrackBar1ValueChanged);
    	// 
    	// toolProp
    	// 
    	this.toolProp.BackColor = System.Drawing.SystemColors.Control;
    	this.toolProp.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
    	this.toolProp.Location = new System.Drawing.Point(0, 49);
    	this.toolProp.Name = "toolProp";
    	this.toolProp.Size = new System.Drawing.Size(484, 25);
    	this.toolProp.TabIndex = 5;
    	this.toolProp.Text = "toolStrip2";
    	// 
    	// maskToolProp
    	// 
    	this.maskToolProp.Image = ((System.Drawing.Image)(resources.GetObject("maskToolProp.Image")));
    	this.maskToolProp.Name = "maskToolProp";
    	this.maskToolProp.Size = new System.Drawing.Size(74, 22);
    	this.maskToolProp.Text = "Mask Edit";
    	// 
    	// normalFieldProp
    	// 
    	this.normalFieldProp.Image = ((System.Drawing.Image)(resources.GetObject("normalFieldProp.Image")));
    	this.normalFieldProp.Name = "normalFieldProp";
    	this.normalFieldProp.Size = new System.Drawing.Size(114, 22);
    	this.normalFieldProp.Text = "Normal Field Edit";
    	// 
    	// startFieldProp
    	// 
    	this.startFieldProp.Image = ((System.Drawing.Image)(resources.GetObject("startFieldProp.Image")));
    	this.startFieldProp.Name = "startFieldProp";
    	this.startFieldProp.Size = new System.Drawing.Size(98, 22);
    	this.startFieldProp.Text = "Start Field Edit";
    	// 
    	// finishFieldProp
    	// 
    	this.finishFieldProp.Image = ((System.Drawing.Image)(resources.GetObject("finishFieldProp.Image")));
    	this.finishFieldProp.Name = "finishFieldProp";
    	this.finishFieldProp.Size = new System.Drawing.Size(105, 22);
    	this.finishFieldProp.Text = "Finish Field Edit";
    	// 
    	// MainForm
    	// 
    	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
    	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    	this.ClientSize = new System.Drawing.Size(484, 364);
    	this.Controls.Add(this.levelView);
    	this.Controls.Add(this.statusStrip1);
    	this.Controls.Add(this.toolProp);
    	this.Controls.Add(this.toolStrip1);
    	this.Controls.Add(this.menuStrip1);
    	this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
    	this.MainMenuStrip = this.menuStrip1;
    	this.MinimumSize = new System.Drawing.Size(300, 250);
    	this.Name = "MainForm";
    	this.Text = "Cubes LevelEditor";
    	this.Resize += new System.EventHandler(this.MainFormResize);
    	this.menuStrip1.ResumeLayout(false);
    	this.menuStrip1.PerformLayout();
    	this.toolStrip1.ResumeLayout(false);
    	this.toolStrip1.PerformLayout();
    	this.statusStrip1.ResumeLayout(false);
    	this.statusStrip1.PerformLayout();
    	this.levelView.ResumeLayout(false);
    	this.levelView.PerformLayout();
    	((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
    	this.ResumeLayout(false);
    	this.PerformLayout();
    }
    private System.Windows.Forms.ToolStripButton toolStripButtonMask;
    private System.Windows.Forms.ToolStripLabel maskToolProp;
    private System.Windows.Forms.ToolStripLabel finishFieldProp;
    private System.Windows.Forms.ToolStripLabel startFieldProp;
    private System.Windows.Forms.ToolStripLabel normalFieldProp;
    private System.Windows.Forms.ToolStrip toolProp;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripButton nextLevelButton;
    private System.Windows.Forms.ToolStripButton prevLevelButton;
    private System.Windows.Forms.TrackBar trackBar1;
    private System.Windows.Forms.ToolStripStatusLabel statusBarTextLabel;
    private System.Windows.Forms.ToolStripMenuItem chooseLevelToolStripMenuItem;
    private System.Windows.Forms.Panel levelView;
    private System.Windows.Forms.ToolStripButton toolStripButtonNormalField;
    private System.Windows.Forms.ToolStripButton toolStripButtonStartField;
    private System.Windows.Forms.ToolStripButton toolStripButtonFinishField;
    private System.Windows.Forms.ToolStripMenuItem levelToolStripMenuItem;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem importBMPToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.MenuStrip menuStrip1;
    
  }
}
