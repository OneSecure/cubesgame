using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Cubes
{
  /// <summary>
  /// The base sigleton controller class.
  /// </summary>
  public sealed class Core
  {
    private static Core instance = null;

    private Level currentLevel;
    private LevelLoader lvlLoader;

    public Level CurrentLevel
    {
      get { return currentLevel; }
      set { currentLevel = value; }
    }

    public LevelLoader LevelLoader
    {
      get { return lvlLoader; }
    }
    
    /// <summary>
    /// Persuades to the next level
    /// </summary>
    public void levelDone(){
      CurrentLevel = lvlLoader.loadLevel(currentLevel.LevelNumber + 1);
    }
    
    /// <summary>
    /// Resets the current level.
    /// </summary>
    public void levelReset(){
      CurrentLevel = lvlLoader.loadLevel(currentLevel.LevelNumber);
    }

    /// <summary>
    /// For getting the base-controler.
    /// </summary>
    /// <returns>The singleton-instance of Core.</returns>
    public static Core Instance{
      get{
        if (instance == null)
  	      instance = new Core();
  	    return instance;
      }
    }
    
    /// <summary>
    /// Initial actions before the first level starts
    /// </summary>
    private Core()
    { 
      lvlLoader = new LevelLoader("level.cls");
      
      CurrentLevel = lvlLoader.loadLevel(0);
      
      ThreadPool.QueueUserWorkItem(Renderer.run);
    }
  }
}
