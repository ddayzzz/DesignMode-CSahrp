using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModeInCSharp.Dectorator
{
    class HTMLFormater : MarkupFormater
    {
        public HTMLFormater(Display display):base(display)
        {
            
        }

        public override int GetColumns()
        {
            return 5 + this.display.GetColumns() + 6; //<pre>...</pre>标签
        }

        public override int GetRows()
        {
            return display.GetRows();
        }

        public override string GetRowText(int row)
        {
            return "<pre>" + this.display.GetRowText(row) + "</pre>";
        }
    }
}
