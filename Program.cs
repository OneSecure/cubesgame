using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Cubes
{
  static class Program
  {
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      
      // Inistializing the Core instance.
      Core core = Core.Instance;

      Application.Run(new MainForm());
    }
  }
}
