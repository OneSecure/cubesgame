using System;
using System.Windows.Forms;
using System.Threading;

namespace Cubes
{
  public class Renderer
  {
    private static Renderer instance = null;
    
    public static void run(object context){
      if(instance == null)
        instance = new Renderer();
    }

    private Renderer()
    {
      while(true){
        Action action = ActionPoll.Instance.Next;
        if(action != null){
          Thread.Sleep(200);
          if(action.Move == Action.MOVE_FALL_DOWN){
            MessageBox.Show("Block falls down.");
            ActionPoll.Instance.clear();
            Core.Instance.levelReset();
          }
          if(action.Move == Action.MOVE_FINISH){
            MessageBox.Show("Level Done...");
            ActionPoll.Instance.clear();
            Core.Instance.levelDone();
          }
        }
      }
    }
  }
}
