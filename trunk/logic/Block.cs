using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Cubes
{
  public class Block {
    private Field[] fields;
    
    public void step(Action action){
      //convert action
      int axis;
      bool positive;
      
      axis = (action.Direction == Action.DIRECTION_NORTH
         || action.Direction == Action.DIRECTION_SOUTH) ?
        Field.Y_AXIS : Field.X_AXIS;
      
      positive = (action.Direction == Action.DIRECTION_NORTH
         || action.Direction == Action.DIRECTION_EAST);
      
      //create pivotfield
      int pivotOnAxis = fields[0].get(axis);
      foreach(Field field in fields){
        if((field.get(axis) > pivotOnAxis) == positive)
          pivotOnAxis = field.get(axis);
      }
      //move fields
      foreach(Field field in fields){
        int dist;
        int heightCorretion = (positive) ? 
          countForPosition(field) : 
          countForPosition(field) * -1;
        dist = pivotOnAxis - field.get(axis) + heightCorretion;
        
        int newFieldOnAxis = field.get(axis) + dist;
        field.set(axis, newFieldOnAxis);
        
        int x = field.X;
        int y = field.Y;
      }
      //test if block is stable
      if(!isBlockStable()){
        ActionPoll.Instance.NewAction = 
            new Action(
              action.Direction, 
              Action.MOVE_FALL_DOWN);
      }
    }
    
    private int countForPosition(Field position){
      int count = 0;
      foreach(Field field in fields)
        if(position.equals(field))
          count++;
      
      return count;
    }

    private bool isBlockStable(){
      foreach(Field field in fields){
        GroundField levelField = Core.Instance.CurrentLevel.getFieldAtPosition(field);
  
        if (levelField == null)
            return false;
        if(levelField is IActivatable)
          if(!((IActivatable)levelField).activate()) return true;
      }
      return true;
    }
  

    public bool isVertical()
    {
      Field testField = fields[0];
      foreach (Field field in fields)
        if (!testField.equals(field)) return false;
      return true;
    }
  
    public Block(int x, int y, int height)
    {
      fields = new Field[height];
  
      for (int i = 0; i < height; i++)
      {
        fields[i] = new Field(x, y);
      }
    }

    public Block(Field[] fields){
      this.fields = fields;
    }
    
    public Block(Field field){
      fields = new Field[2];
      fields[0] = new Field(field.X, field.Y);
      fields[1] = new Field(field.X, field.Y);
    }
  }
}
