using System;
using System.Drawing;
using clsFileLib;
using System.Collections.Generic;

namespace LevelEditor
{
  public class LevelView
  {
    private int width  = -1;
    private int height = -1;
    private Graphics g = null;
        
    public void drawView(Graphics g){
      this.g = g;
      width = (int)g.VisibleClipBounds.Width;
      height = (int)g.VisibleClipBounds.Height;
            
      Brush backBrush = Brushes.Black;
      g.FillRectangle(backBrush, 0, 0, width, height);
      
      drawLevel();
      drawGrid();
    }
    
    public void drawThumbView(Graphics g, int levelIndex){
      EditorState backup = Core.Instance.State.clone();
      
      Core.Instance.State.LevelViewFieldSize = 3;
      Core.Instance.State.LevelIndex = levelIndex;
      
      this.g = g;
      width = (int)g.VisibleClipBounds.Width;
      height = (int)g.VisibleClipBounds.Height;
      
      drawLevel();
      
      g.DrawString("-" + (levelIndex + 1) + "-", new Font(FontFamily.GenericSansSerif, 10), Brushes.White, 3, 3);
      
      Core.Instance.State = backup;
    }
       
    private void drawLevel(){
      ClsLevel level = Core.Instance.LevelList.getLevel(
       Core.Instance.State.LevelIndex);
      
      foreach(byte[] fieldBytes in level.BytesList){
        bool isMaskSet = false;
        bool hasAnyMask = fieldBytes[3] != 0;
        
        if(Core.Instance.State.Mask >= 0)
          isMaskSet = ((fieldBytes[3] & (byte)(Math.Pow(2, Core.Instance.State.Mask))) != 0);
        
        drawField(fieldBytes[0], fieldBytes[1], fieldBytes[2], isMaskSet, hasAnyMask);
      }
    }
    
    private void drawField(int type, int x, int y, bool isMaskSet, bool hasAnyMask){
      Brush fieldBrush;
      
      if(type == ClsConst.FTYPE_START) 
        fieldBrush = Brushes.Red;
      else if(type == ClsConst.FTYPE_FINISH) 
        fieldBrush = Brushes.Green;
      else
        fieldBrush = Brushes.White;
      
      int fieldSize = Core.Instance.State.LevelViewFieldSize;
      
      int xPx = x * fieldSize;
      int yPx = height - (y + 1) * fieldSize;
      
      g.FillRectangle(fieldBrush, 
                      xPx, yPx,
                      fieldSize, fieldSize);
      
      if(isMaskSet || hasAnyMask){
        Point[] triangle = new Point[3];
        triangle[0] = new Point(xPx, yPx);
        triangle[1] = new Point(xPx + fieldSize / 2, yPx);
        triangle[2] = new Point(xPx, yPx + fieldSize / 2);
        
        Brush maskBrush = (isMaskSet) ? Brushes.Black : Brushes.Gray;
        g.FillPolygon(maskBrush, triangle);
      }
    }
    
    private void drawGrid(){      
      Pen gridPen = Pens.DarkGray;
      
      for(int x = Core.Instance.State.LevelViewFieldSize;
          x < width;
          x += Core.Instance.State.LevelViewFieldSize)
            g.DrawLine(gridPen, 
                       x, 0,
                       x, height);
      
      for(int y = height - Core.Instance.State.LevelViewFieldSize;
          y > 0;
          y -= Core.Instance.State.LevelViewFieldSize)
            g.DrawLine(gridPen, 
                       0, y,
                       width, y);
    }
    
    public byte[] translate(Point p){
      byte[] field = new byte[4];
      
      field[1] = (byte)(p.X / Core.Instance.State.LevelViewFieldSize);      
      field[2] = (byte)((height - p.Y) / Core.Instance.State.LevelViewFieldSize);
      
      return field;
    }
    
    public LevelView(){}
  }
}
