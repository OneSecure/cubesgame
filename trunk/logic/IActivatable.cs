using System;
using System.Collections.Generic;
using System.Text;

namespace Cubes
{
  interface IActivatable
  {
    /// <returns>false if no further check of the block-stability is neccessary</returns>
    bool activate();
  }
}
