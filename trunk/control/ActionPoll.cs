using System;
using System.Collections.Generic;

namespace Cubes
{
  /// <summary>
  /// Description of ActionPoll.
  /// </summary>
  public class ActionPoll
  {
    private List<Action> actionList;
    private static ActionPoll instance = null;
    
    public static ActionPoll Instance{
      get{
        if(instance == null)
          instance = new ActionPoll();
        return instance;
      }
    }
    
    public Action Next{
      get{
        if(actionList.Count == 0)
          return null;
        
        Action action = actionList[0];
        actionList.RemoveAt(0);
        return action;
      }
    }
    
    public Action NewAction{
      set{
        actionList.Add(value);
      }
    }
    
    public void clear(){
      actionList.Clear();
    }
    
    private ActionPoll(){
      actionList = new List<Action>();
    }
  }
}
