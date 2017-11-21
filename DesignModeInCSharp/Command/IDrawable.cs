using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModeInCSharp.Command
{
    interface IDrawable
    {
        System.Drawing.Graphics Draw(int x, int y);
    }
}
