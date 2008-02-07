using System;
using System.Drawing;
using System.Windows.Forms;

namespace LevelEditor
{
  public partial class LevelsForm : Form
  {
    private int selectedThumbIndex = -1;
    private Panel[] levelThumbs = null;
      
    public LevelsForm(){
      InitializeComponent();
      initThumbsList();
      setSelectedThumb(Core.Instance.State.LevelIndex);
    }
    
    private void initThumbsList(){
      int levelCount = (int)Core.Instance.LevelList.getLength();
      
      levelThumbs = new Panel[levelCount];
      thumbBox.Controls.Clear();
      
      for(int i = 0; i < levelCount; i++){
        Panel panel = new Panel();
        levelThumbs[i] = panel;
        
        thumbBox.Controls.Add(panel);
        
        panel.Tag = i;
        panel.Size = new Size(100, 100);
        panel.Location = new Point(10, 10 + i * 110);
        
        panel.Paint += new PaintEventHandler(levelThumbPaint);
        panel.ForeColor = Color.White;
        panel.Text = "(" + i + ")";
        panel.BackColor = Color.Black;
        
        panel.MouseClick += new MouseEventHandler(levelThumbSelect);
        panel.MouseDoubleClick += new MouseEventHandler(levelThumbOpen);
      }
    }
    
    private void setSelectedThumb(int index){
      if(selectedThumbIndex >= 0)
        levelThumbs[selectedThumbIndex].BackColor = Color.Black;
      
      if(index >= 0){
        levelThumbs[index].BackColor = Color.DimGray;
        thumbBox.ScrollControlIntoView(levelThumbs[index]);
      }
      selectedThumbIndex = index;
    }
    
    private void levelThumbSelect(object sender, MouseEventArgs e){
      setSelectedThumb((int)(((Panel)sender).Tag));
    }
    
    private void levelThumbOpen(object sender, MouseEventArgs e){
      Core.Instance.State.LevelIndex = (int)(((Panel)sender).Tag);
      redrawParent();
      this.Close();
    }
    
    private void levelThumbPaint(object sender, PaintEventArgs e){
      Graphics g = ((Panel)sender).CreateGraphics();
      int levelIndex = (int)(((Panel)sender).Tag);
      Core.Instance.View.drawThumbView(g, levelIndex);
    }
    
    private void OkButtonClick(object sender, EventArgs e)
    {
      this.Close();
    }
        
    void MoveUpButtonClick(object sender, EventArgs e)
    {
      if(selectedThumbIndex > 0){
        Core.Instance.LevelMod.moveLevelUp(selectedThumbIndex - 1);
        setSelectedThumb(selectedThumbIndex - 1);
        redrawParent();
        redrawThumbBox();
    }
    }
    
    void MoveDownButtonClick(object sender, EventArgs e)
    {
      if(selectedThumbIndex + 1 < Core.Instance.LevelList.getLength()){
        Core.Instance.LevelMod.moveLevelUp(selectedThumbIndex);
        setSelectedThumb(selectedThumbIndex + 1);
        redrawParent();
        redrawThumbBox();
      }
    }
    
    private void redrawParent(){
      ((MainForm)this.Owner).redrawLevelView();
    }
    
    private void redrawThumbBox(){
      foreach(Control thumb in thumbBox.Controls)
        thumb.Invalidate();
    }
    
    void AddButtonClick(object sender, EventArgs e)
    {
      Core.Instance.LevelList.addLevel();
      initThumbsList();
      setSelectedThumb((int)Core.Instance.LevelList.getLength() - 1);
      redrawParent();
      redrawThumbBox();
    }
    
    void RemoveButtonClick(object sender, EventArgs e)
    {
      if(selectedThumbIndex >= 0){
        Core.Instance.LevelList.removeLevel(selectedThumbIndex);
        initThumbsList();
        selectedThumbIndex = -1;
        redrawParent();
        redrawThumbBox();
      }
    }
  }
}
