namespace LevelEditor
{
  partial class LevelsForm
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
    	this.panel1 = new System.Windows.Forms.Panel();
    	this.moveDownButton = new System.Windows.Forms.Button();
    	this.moveUpButton = new System.Windows.Forms.Button();
    	this.okButton = new System.Windows.Forms.Button();
    	this.removeButton = new System.Windows.Forms.Button();
    	this.addButton = new System.Windows.Forms.Button();
    	this.thumbBox = new System.Windows.Forms.Panel();
    	this.panel1.SuspendLayout();
    	this.SuspendLayout();
    	// 
    	// panel1
    	// 
    	this.panel1.Controls.Add(this.moveDownButton);
    	this.panel1.Controls.Add(this.moveUpButton);
    	this.panel1.Controls.Add(this.okButton);
    	this.panel1.Controls.Add(this.removeButton);
    	this.panel1.Controls.Add(this.addButton);
    	this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
    	this.panel1.Location = new System.Drawing.Point(142, 5);
    	this.panel1.Name = "panel1";
    	this.panel1.Size = new System.Drawing.Size(87, 254);
    	this.panel1.TabIndex = 0;
    	// 
    	// moveDownButton
    	// 
    	this.moveDownButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
    	    	    	| System.Windows.Forms.AnchorStyles.Right)));
    	this.moveDownButton.Location = new System.Drawing.Point(6, 119);
    	this.moveDownButton.Name = "moveDownButton";
    	this.moveDownButton.Size = new System.Drawing.Size(75, 23);
    	this.moveDownButton.TabIndex = 4;
    	this.moveDownButton.Text = "Move Down";
    	this.moveDownButton.UseVisualStyleBackColor = true;
    	this.moveDownButton.Click += new System.EventHandler(this.MoveDownButtonClick);
    	// 
    	// moveUpButton
    	// 
    	this.moveUpButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
    	    	    	| System.Windows.Forms.AnchorStyles.Right)));
    	this.moveUpButton.Location = new System.Drawing.Point(6, 90);
    	this.moveUpButton.Name = "moveUpButton";
    	this.moveUpButton.Size = new System.Drawing.Size(75, 23);
    	this.moveUpButton.TabIndex = 3;
    	this.moveUpButton.Text = "Move Up";
    	this.moveUpButton.UseVisualStyleBackColor = true;
    	this.moveUpButton.Click += new System.EventHandler(this.MoveUpButtonClick);
    	// 
    	// okButton
    	// 
    	this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
    	    	    	| System.Windows.Forms.AnchorStyles.Right)));
    	this.okButton.Location = new System.Drawing.Point(6, 228);
    	this.okButton.Name = "okButton";
    	this.okButton.Size = new System.Drawing.Size(75, 23);
    	this.okButton.TabIndex = 2;
    	this.okButton.Text = "Ok";
    	this.okButton.UseVisualStyleBackColor = true;
    	this.okButton.Click += new System.EventHandler(this.OkButtonClick);
    	// 
    	// removeButton
    	// 
    	this.removeButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
    	    	    	| System.Windows.Forms.AnchorStyles.Right)));
    	this.removeButton.Location = new System.Drawing.Point(6, 32);
    	this.removeButton.Name = "removeButton";
    	this.removeButton.Size = new System.Drawing.Size(75, 23);
    	this.removeButton.TabIndex = 1;
    	this.removeButton.Text = "Remove";
    	this.removeButton.UseVisualStyleBackColor = true;
    	this.removeButton.Click += new System.EventHandler(this.RemoveButtonClick);
    	// 
    	// addButton
    	// 
    	this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
    	    	    	| System.Windows.Forms.AnchorStyles.Right)));
    	this.addButton.Location = new System.Drawing.Point(6, 3);
    	this.addButton.Name = "addButton";
    	this.addButton.Size = new System.Drawing.Size(75, 23);
    	this.addButton.TabIndex = 0;
    	this.addButton.Text = "Add";
    	this.addButton.UseVisualStyleBackColor = true;
    	this.addButton.Click += new System.EventHandler(this.AddButtonClick);
    	// 
    	// thumbBox
    	// 
    	this.thumbBox.AutoScroll = true;
    	this.thumbBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
    	this.thumbBox.Dock = System.Windows.Forms.DockStyle.Fill;
    	this.thumbBox.Location = new System.Drawing.Point(5, 5);
    	this.thumbBox.Name = "thumbBox";
    	this.thumbBox.Size = new System.Drawing.Size(137, 254);
    	this.thumbBox.TabIndex = 1;
    	// 
    	// LevelsForm
    	// 
    	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
    	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    	this.ClientSize = new System.Drawing.Size(234, 264);
    	this.Controls.Add(this.thumbBox);
    	this.Controls.Add(this.panel1);
    	this.MaximizeBox = false;
    	this.MaximumSize = new System.Drawing.Size(250, 2000);
    	this.MinimizeBox = false;
    	this.MinimumSize = new System.Drawing.Size(250, 300);
    	this.Name = "LevelsForm";
    	this.Padding = new System.Windows.Forms.Padding(5);
    	this.ShowIcon = false;
    	this.Text = "Levels";
    	this.panel1.ResumeLayout(false);
    	this.ResumeLayout(false);
    }
    private System.Windows.Forms.Button removeButton;
    private System.Windows.Forms.Button addButton;
    private System.Windows.Forms.Button moveUpButton;
    private System.Windows.Forms.Button moveDownButton;
    private System.Windows.Forms.Button okButton;
    private System.Windows.Forms.Panel thumbBox;
    private System.Windows.Forms.Panel panel1;
  }
}
