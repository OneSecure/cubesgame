using System;
using System.Text;
using System.IO;
using System.Collections.Generic;
using System.Drawing;

namespace clsFileLib
{
  public class ClsBmpFileImporter
  {
    public static ClsLevelList importBmpFile(String fileName){
      ClsLevelList levelList = new ClsLevelList();
      
      // Read File
      FileStream levelStream = File.OpenRead(fileName);
      Bitmap levelMap = new Bitmap(levelStream);
      int levelSize = levelMap.Height;
      long levelCount = levelMap.Width / levelMap.Height;
      
      levelStream.Close();
      
      // Parse Bitmap
      for(int i = 0; i < levelCount; i++){
        
        List<byte[]> bytesList = new List<byte[]>();
        
        for (int x = 0; x < levelSize; x++){
          for (int y = 0; y < levelSize; y++){
            Color fieldColor = levelMap.GetPixel(x + levelSize * i, levelSize - y - 1);
      
            byte[] newField = new byte[4];
            newField[0] = ClsConst.FTYPE_UNKNOWN;
            newField[1] = (byte)x;
            newField[2] = (byte)y;
            
            if(fieldColor.Equals(Color.FromArgb(255, 255, 255, 255))) 
              newField[0] = ClsConst.FTYPE_NORMAL;
    
            if (fieldColor.Equals(Color.FromArgb(255, 0, 255, 0)))
              newField[0] = ClsConst.FTYPE_FINISH;
    
            if (fieldColor.Equals(Color.FromArgb(255, 255, 0, 0)))
              newField[0] = ClsConst.FTYPE_START;
    
            if (newField[0] != ClsConst.FTYPE_UNKNOWN) 
              bytesList.Add(newField);
          }
        }
        
        levelList.addLevel(new ClsLevel(bytesList));
      }
      
      return levelList;
    }
  }
}
