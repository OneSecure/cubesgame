using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using clsFileLib;

namespace Cubes
{
  public class LevelLoader
  {
    private ClsLevelList levelList = null;
    
    private void loadFile(String levelFile){
      levelList = ClsFileReader.readClsFile(levelFile);
    }
    
    private void byteFieldToLevel(byte[] byteField, Level level){
      
      Field field = new Field(byteField[1], byteField[2]);
      
      if(byteField[0] == ClsConst.FTYPE_NORMAL){
        level.addField(new GroundField(field));
      }
      else if(byteField[0] == ClsConst.FTYPE_START){
        level.addField(new GroundField(field));
        level.addBlock(new Block(field));
      }
      else if(byteField[0] == ClsConst.FTYPE_FINISH){
        level.addField(new FinishGroundField(field));
      }      
    }
    
    public Level loadLevel(int levelNumber){
      
      if(levelNumber >= levelList.getLength()){
        MessageBox.Show("All levels done, exiting...");
        Application.Exit();
      }
            
      Level level = new Level(levelNumber);
      
      List<byte[]> levelBytesList = levelList.getLevel(levelNumber).BytesList;
      foreach(byte[] byteField in levelBytesList){
        byteFieldToLevel(byteField, level);
      }
      return level;
    }
    
    public LevelLoader(String levelFile){
      loadFile(levelFile);
    }
  }
}
