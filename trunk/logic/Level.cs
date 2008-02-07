using System;
using System.Collections.Generic;
using System.Text;

namespace Cubes
{
  public class Level : IEnumerable<GroundField>
  {
    private List<GroundField> levelSpace;
    private List<Block> blocks;
    private int activeBlock = 0;
    private int levelNumber = -1;
    
    public int LevelNumber{
      get{return levelNumber;}
    }
    
    public void addField(GroundField field)
    {
      levelSpace.Add(field);
    }

    public Block getBlock(int index)
    {
      return blocks[index];
    }

    public Block getActiveBlock()
    {
      return getBlock(activeBlock);
    }

    public void addBlock(Block block)
    {
      blocks.Add(block);
    }

    public GroundField getFieldAtPosition(Field position)
    {
      foreach (GroundField levelSpaceField in levelSpace) {
        if(levelSpaceField.equals(position))
          return levelSpaceField;
      }
      return null;
    }


    public Level(int levelNumber)
    {
      this.levelNumber = levelNumber;
      blocks = new List<Block>();
      levelSpace = new List<GroundField>();
    }
  	
    
	public IEnumerator<GroundField> GetEnumerator()
	{
		return levelSpace.GetEnumerator();
	}
  	
  	
	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return levelSpace.GetEnumerator();
	}
  }
}
