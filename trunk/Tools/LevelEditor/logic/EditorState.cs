using System;
using clsFileLib;

namespace LevelEditor
{
  public class EditorState
  {
    public const int TOOL_NORMAL  = ClsConst.FTYPE_NORMAL;
    public const int TOOL_START   = ClsConst.FTYPE_START;
    public const int TOOL_FINISH  = ClsConst.FTYPE_FINISH;
    public const int TOOL_MASKS   = 254;
    
    private int levelIndex = 0;
    private int selectedTool = -1;
    private String levelFile = "";
    private int levelViewFieldSize = 20;
    private int mask = -1;
    
    public int Mask{
      get{return mask;}
      set{mask = value;}
    }
    
    public EditorState clone(){
      EditorState clone = new EditorState();

      clone.LevelIndex = levelIndex;
      clone.SelectedTool = selectedTool;
      clone.LevelFile = (String)levelFile.Clone();
      clone.LevelViewFieldSize = levelViewFieldSize;
      
      return clone;
    }
    
    public int LevelIndex{
      get{ return levelIndex;}
      set{ levelIndex = value;}
    }
    
    public int SelectedTool{
      get{ return selectedTool;}
      set{ selectedTool = value;}
    }
    
    public String LevelFile{
      get{ return levelFile;}
      set{ levelFile = value;}
    }
    
    public int LevelViewFieldSize{
      get{ return levelViewFieldSize;}
      set{ if(value > 0) levelViewFieldSize = value;}
    }
    
    public EditorState()
    {
    }
  }
}
