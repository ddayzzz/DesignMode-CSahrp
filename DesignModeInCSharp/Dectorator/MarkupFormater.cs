using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModeInCSharp.Dectorator
{
    abstract class MarkupFormater : Display
    {
        protected Display display;

        public MarkupFormater(Display display)
        {
            this.display = display;
        }
    }
}
