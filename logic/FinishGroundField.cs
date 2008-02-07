using System;
using System.Windows.Forms;

namespace Cubes
{
  public class FinishGroundField : GroundField, IActivatable
	{
    public bool activate()
    {
      if (Core.Instance.CurrentLevel.getActiveBlock().isVertical())
      {
        ActionPoll.Instance.NewAction = new Action(0, Action.MOVE_FINISH);
        return false;
      }
      return true;
    }
    
    public FinishGroundField(int x, int y) : base(x,y)
		{
		}
    public FinishGroundField(Field field) : base(field.X, field.Y)
		{
		}
	}
}
