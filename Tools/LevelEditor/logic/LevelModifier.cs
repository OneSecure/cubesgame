using System;
using clsFileLib;
using System.Collections.Generic;

namespace LevelEditor
{
  public class LevelModifier
  {
    public void toolClick(byte[] inputField){
      List<Byte[]> levelFields = 
        Core.Instance.LevelList.getLevel(
          Core.Instance.State.LevelIndex).BytesList;
    
      foreach(byte[] levelField in levelFields){
        if(levelField[1] == inputField[1] &&
           levelField[2] == inputField[2]){
          toolClickedField(levelField);
          return;
        }
      }
      
      if(Core.Instance.State.SelectedTool == EditorState.TOOL_NORMAL){
        inputField[0] = ClsConst.FTYPE_NORMAL;
        levelFields.Add(inputField);
      }
    }
    
    private void toolClickedField(byte[] levelField){
      if(Core.Instance.State.SelectedTool == EditorState.TOOL_NORMAL){
         Core.Instance.LevelList.getLevel(
         Core.Instance.State.LevelIndex).BytesList.Remove(levelField);
      }
      else if(Core.Instance.State.SelectedTool == EditorState.TOOL_START ||
              Core.Instance.State.SelectedTool == EditorState.TOOL_FINISH){
        levelField[0] = 
          (levelField[0] == ClsConst.FTYPE_NORMAL) ?
          (byte)Core.Instance.State.SelectedTool : ClsConst.FTYPE_NORMAL;
      }
      else if(Core.Instance.State.SelectedTool == EditorState.TOOL_MASKS){
        levelField[3] ^= (byte)(Math.Pow(2, Core.Instance.State.Mask));
      }
    }
    
    public void moveLevelUp(int index){
      ClsLevelList newList = new ClsLevelList();
      ClsLevelList coreList = Core.Instance.LevelList;
      
      for(int i = 0; i < coreList.getLength(); i++){
        if(i == index)
          newList.addLevel(coreList.getLevel(index + 1));
        else if(i == index + 1)
          newList.addLevel(coreList.getLevel(index));
        else
          newList.addLevel(coreList.getLevel(i));
      }
      Core.Instance.LevelList = newList;
    }
    
    public LevelModifier(){}
  }
}
