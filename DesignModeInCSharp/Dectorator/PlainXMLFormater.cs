using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModeInCSharp.Dectorator
{
    /// <summary>
    /// 装饰为
    /// </summary>
    class PlainXMLFormater : MarkupFormater
    {
        public PlainXMLFormater(Display display):base(display)
        {

        }
        public override int GetColumns()
        {
            return 11 + display.GetColumns();
        }

        public override int GetRows()
        {
            return this.display.GetRows() + 2;
        }

        public override string GetRowText(int row)
        {
            if (row == 0)
                return "------\n" + this.display.GetRowText(row) + "\n------";
            else
                return null;
        }
    }
}
