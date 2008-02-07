using System;
using System.IO;
using System.Collections.Generic;

namespace clsFileLib
{
  public class ClsLevel
  {
    private const int BPF = 4; // Bytes Per Field
    private List<byte[]> binaryLevelFields;
    
    public int FieldCount{
      get{return binaryLevelFields.Count;}
    }
    
    public long ByteCount{
      get{return binaryLevelFields.Count * BPF;}
    }
    
    public List<byte[]> BytesList{
      get{return binaryLevelFields;}
      set{binaryLevelFields = value;}
    }
    
    public byte[] Bytes{
      get{return getBytes();}
      set{setBytes(value);}
    }
    
    private byte[] getBytes(){
      byte[] byteArray = new byte[binaryLevelFields.Count * BPF];
      for(int byteNo = 0; byteNo < binaryLevelFields.Count * BPF; byteNo++)
        byteArray[byteNo] = binaryLevelFields[(int)byteNo / BPF][byteNo % BPF];
      return byteArray;
    }
    
    private void setBytes(byte[] bytes){
      binaryLevelFields = new List<byte[]>();
      
      byte[] binField = new byte[BPF];
      for(long byteNo = 0; byteNo < bytes.Length; byteNo++){
        
        int index = (int)byteNo % BPF;
        binField[index] = bytes[byteNo];
        if(index == BPF - 1)
          binaryLevelFields.Add((byte[])binField.Clone());
      }
    }
    
    public ClsLevel(byte[] binaryLevelData){
      Bytes = binaryLevelData;
    }
    
    public ClsLevel(List<byte[]> bytesList){
      BytesList = bytesList;
    }
  }
}
