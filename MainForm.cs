using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cubes
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
    }

    protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
    {
      Action action = null;
      switch (keyData)
      {
        case Keys.Left: 
          action = new Action(
              Action.DIRECTION_WEST, 
              Action.MOVE_STEP);
          break;
        case Keys.Right:
          action = new Action(
              Action.DIRECTION_EAST, 
              Action.MOVE_STEP);
          break;
        case Keys.Up:
          action = new Action(
              Action.DIRECTION_NORTH, 
              Action.MOVE_STEP);
          break;
        case Keys.Down:
          action = new Action(
              Action.DIRECTION_SOUTH, 
              Action.MOVE_STEP);
          break;
      }
      
      ActionPoll.Instance.NewAction = action;
      Core.Instance.CurrentLevel.getActiveBlock().step(action);
      return base.ProcessCmdKey(ref msg, keyData);
    }
  }
}
