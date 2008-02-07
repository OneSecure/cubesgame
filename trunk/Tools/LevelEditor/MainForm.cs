using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using clsFileLib;

namespace LevelEditor
{
  public partial class MainForm : Form
  {
    private FileDialog fileDialog = null;
    
    public MainForm()
    {
      InitializeComponent();
    }
    
    public void redrawLevelView(){
      levelView.Invalidate();
    }
    
    private void maskChanged(object sender, EventArgs e){
      foreach(ToolStripItem mask in toolProp.Items)
        if(mask is ToolStripButton) ((ToolStripButton)mask).Checked = false;
      ((ToolStripButton)sender).Checked = true;
      
      Core.Instance.State.Mask = (int)(((ToolStripButton)sender).Tag);
      redrawLevelView();
    }
    
    private void toolChanged(object sender, EventArgs e)
    {
      Core.Instance.State.Mask = -1;
      Core.Instance.State.SelectedTool = (int)(((ToolStripButton) sender).Tag);
      
      updateToolPropBar();
      redrawLevelView();
    }
    
    private void setCurrentFile(String fileName){
      statusBarTextLabel.Text = fileName;
      Core.Instance.State.LevelFile = fileName;
    }
    
    private void OpenToolStripMenuItemClick(object sender, EventArgs e)
    {
      fileDialog = new OpenFileDialog();
      fileDialog.Title = "Open Cubes LevelsFile...";
      fileDialog.DefaultExt = "cls";
      fileDialog.Filter = "Cubes LevelsFile |*.cls";
      
      if(fileDialog.ShowDialog() == DialogResult.OK){
        Core.Instance.LevelList = 
            ClsFileReader.readClsFile(fileDialog.FileName);
        setCurrentFile(fileDialog.FileName);
        levelView.Invalidate();
      }
    }
    
    private void SaveToolStripMenuItemClick(object sender, EventArgs e)
    {
      String fileName = Core.Instance.State.LevelFile;
      if(fileName != null)
        ClsFileWriter.writeClsFile(fileName, Core.Instance.LevelList);
    }
    
    private void SaveAsToolStripMenuItemClick(object sender, EventArgs e)
    {    	
    	fileDialog = new SaveFileDialog();
      fileDialog.Title = "Save Cubes LevelsFile As...";
      fileDialog.DefaultExt = "cls";
      fileDialog.Filter = "Cubes LevelsFile |*.cls";
      fileDialog.FileName = Core.Instance.State.LevelFile;
      
      if(fileDialog.ShowDialog() == DialogResult.OK){
        ClsFileWriter.writeClsFile(fileDialog.FileName, Core.Instance.LevelList);
        
        setCurrentFile(fileDialog.FileName);
      }
    }
    
    private void ImportBMPToolStripMenuItemClick(object sender, EventArgs e)
    {
    	fileDialog = new OpenFileDialog();
      fileDialog.Title = "Import Bitmap...";
      fileDialog.DefaultExt = "bmp";
      fileDialog.Filter = "Windows Bitmap |*.bmp";
      
      if(fileDialog.ShowDialog() == DialogResult.OK){
        Core.Instance.LevelList = 
            ClsBmpFileImporter.importBmpFile(fileDialog.FileName);
        
        setCurrentFile(fileDialog.FileName.Replace(".bmp", ".cls"));
        levelView.Invalidate();
      }
    }
    
    private void ExitToolStripMenuItemClick(object sender, EventArgs e)
    {
      Application.Exit();
    }
    
    private void LevelViewPaint(object sender, PaintEventArgs e)
    {
      Core.Instance.View.drawView(e.Graphics);
    }
    
    private void MainFormResize(object sender, EventArgs e)
    {
      Core.Instance.View.drawView(levelView.CreateGraphics());
    }
    
    private void LevelViewMouseDown(object sender, MouseEventArgs e)
    {
      byte[] field = Core.Instance.View.translate(e.Location);
      Core.Instance.LevelMod.toolClick(field);
      Core.Instance.View.drawView(levelView.CreateGraphics());
    }
    
    private void TrackBar1ValueChanged(object sender, EventArgs e)
    {
      Core.Instance.State.LevelViewFieldSize = ((TrackBar)sender).Value;
      Core.Instance.View.drawView(levelView.CreateGraphics());
    }
    
    private void ChooseLevelToolStripMenuItemClick(object sender, EventArgs e)
    {
      LevelsForm levelsForm = new LevelsForm();
      levelsForm.ShowDialog(this);
    }
    
    private void PrevLevelButtonClick(object sender, EventArgs e)
    {
      int levelIndex = Core.Instance.State.LevelIndex;
      if(levelIndex > 0)
        Core.Instance.State.LevelIndex = levelIndex - 1;
      redrawLevelView();
    }
    
    private void NextLevelButtonClick(object sender, EventArgs e)
    {
    	int levelIndex = Core.Instance.State.LevelIndex;
    	if(levelIndex + 1 < Core.Instance.LevelList.getLength())
        Core.Instance.State.LevelIndex = levelIndex + 1;
      redrawLevelView();
    }
    
    private void updateToolPropBar(){
      toolProp.Items.Clear();
      
      switch(Core.Instance.State.SelectedTool){
        case EditorState.TOOL_NORMAL:
          toolProp.Items.Add(normalFieldProp);
          break;
          
        case EditorState.TOOL_START:
          toolProp.Items.Add(startFieldProp);
          break;
          
        case EditorState.TOOL_FINISH:
          toolProp.Items.Add(finishFieldProp);
          break;
          
        case EditorState.TOOL_MASKS:
          toolProp.Items.Add(maskToolProp);
          
          for(int i = 0; i < 8; i++){
            ToolStripButton newButton = new ToolStripButton();
            newButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            newButton.Size = new System.Drawing.Size(23, 22);
            newButton.Text = "" + (i + 1);
        	  newButton.Tag = i;
        	  newButton.Click += new EventHandler(maskChanged);
        	  toolProp.Items.Add(newButton);
          }
          break;
      }
    }
  }
}
