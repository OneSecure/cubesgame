using System;
using System.IO;
using System.Collections.Generic;

namespace clsFileLib
{

  public class ClsFileReader
  {  	 	  	
  	public static ClsLevelList readClsFile(String levelFile){
  	  ClsLevelList levelList = new ClsLevelList();
  	  
  	  FileStream levelStream = File.OpenRead(levelFile);
      BinaryReader binReader = new BinaryReader(levelStream);
      
      // Read TOC
      int levelCount = (int)binReader.ReadInt64();
      long[] toc = new long[levelCount];
      for(int i = 0; i < levelCount; i++)
        toc[i] = binReader.ReadInt64();
      
      // Read Body
      for(int i = 0; i < levelCount; i++)        
        levelList.addLevel(
          binReader.ReadBytes(
            (int)binReader.ReadInt64()));
      
      levelStream.Close();
      return levelList;
  	}
  }
}
