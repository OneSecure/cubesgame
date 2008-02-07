using System;
using clsFileLib;

namespace LevelEditor
{
  public class Core
  {
    private static Core instance = null;
    private ClsLevelList levelList = null;
    private EditorState state = null;
    private LevelView levelView = null;
    private LevelModifier levelModifier = null;
    
    public ClsLevelList LevelList{
      get{
        if(levelList == null){
          levelList = new ClsLevelList();
          levelList.addLevel();
        }
        return levelList;
      }
      set{
        levelList = value;
      }
    }
    
    public static Core Instance{
      get{
        if(instance == null)
          instance = new Core();
        return instance;
      }
    }
    
    public LevelModifier LevelMod{
      get{
        if(levelModifier == null)
          levelModifier = new LevelModifier();
        return levelModifier;
      }
    }
    
    public EditorState State{
      get{
        if(state == null)
          state = new EditorState();
        return state;
      }
      set{
        state = value;
      }
    }
    
    public LevelView View{
      get{
        if(levelView == null)
          levelView = new LevelView();
        return levelView;
      }
    }
    
    private Core(){}
  }
}
