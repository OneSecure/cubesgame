using System;
using System.Collections.Generic;

namespace clsFileLib
{
  public class ClsLevelList
  {
    private List<ClsLevel> levelList;
    
    public void addLevel(){
      addLevel(new byte[0]);
    }
    
    public void addLevel(ClsLevel level){
      levelList.Add(level);
    }
    
    public void addLevel(byte[] bytes){
      levelList.Add(new ClsLevel(bytes));
    }
    
    public ClsLevel getLevel(int index){
      return levelList[index];
    }
      
    public void removeLevel(int index){
      levelList.RemoveAt(index);
    }
    
    public long getLength(){
      return (long)levelList.Count;
    }
    
    public void clear(){
      levelList.Clear();
    }
    
    public ClsLevelList()
    {
      levelList = new List<ClsLevel>();
    }
  }
}
