using System;
using System.IO;
using System.Collections.Generic;

namespace clsFileLib
{
  public class ClsFileWriter
  {
    public static void writeClsFile(String fileName, ClsLevelList levelList){
      FileStream output = File.Create(fileName);
      BinaryWriter binWriter = new BinaryWriter(output);
      
      // Prepare TOC
      long levelCount = levelList.getLength();
      binWriter.Write(levelCount);
      long[] toc = new long[levelCount];
      
      // Write Body
      binWriter.BaseStream.Position = 8 + 8 * levelCount;
      
      for(int i = 0; i < levelCount; i++){
        toc[i] = binWriter.BaseStream.Position;
        
        ClsLevel level = levelList.getLevel(i);
        byte[] bytes = level.Bytes;
        binWriter.Write((long)bytes.Length);
        binWriter.Write(bytes);
      }
      
      // Write TOC
      binWriter.BaseStream.Position = 8;
      
      for(int i = 0; i < levelCount; i++)
        binWriter.Write(toc[i]);
      
      output.Close();
    }
  }
}
