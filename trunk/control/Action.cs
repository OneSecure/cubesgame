using System;

namespace Cubes
{
  /// <summary>
  /// Description of Action.
  /// </summary>
  public class Action
  {
  	public const int DIRECTION_NORTH  = 0;
  	public const int DIRECTION_SOUTH  = 1;
  	public const int DIRECTION_WEST   = 2;
  	public const int DIRECTION_EAST   = 3;
  	  
  	public const int MOVE_STEP         = 0;
  	public const int MOVE_FALL_DOWN    = 1;
  	public const int MOVE_FINISH       = 2;
  	
  	public const int MOVE_REDRAW_LEVEL = 3;
    
    private int direction;
    private int move;
    
    public int Direction{
      get{ return direction;}
    }
    
    public int Move{
      get{ return move;}
    }
        
    public Action(int direction, int move){
      this.direction = direction;
      this.move = move;
    }
  }
}
