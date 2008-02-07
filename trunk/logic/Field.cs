using System;

namespace Cubes
{
	public class Field
	{
	  private int x = 0;
	  private int y = 0;
	  
	  public const int X_AXIS = 0;
	  public const int Y_AXIS = 1;
	  
	  public int X{
	    get{return x;}
	    set{x = value;}
	  }
	  
	  public int Y{
	    get{return y;}
	    set{y = value;}
	  }
	  
	  public int get(int axis){
	    if(axis == X_AXIS) return x;
	    if(axis == Y_AXIS) return y;
	    return 0;
	  }
	  
	  public void set(int axis, int val){
	    if(axis == X_AXIS) x = val;
	    if(axis == Y_AXIS) y = val;
	  }
	  
	  public bool equals(Field field){
	    return (x == field.X && y == field.Y);
	  }
	  
	  public Field clone(){
	    return new Field(x, y);
	  }
	  
		public Field(int x, int y)
		{
		  this.x = x;
		  this.y = y;
		}
	}
}
