using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeInCSharp.Dectorator
{
    public class StringDisplay : Dectorator.Display
    {
        private string str;

        public StringDisplay(string str)
        {
            this.str = str;
        }

        public override int GetRows()
        {
            return 1;
        }

        public override int GetColumns()
        {
            return Encoding.UTF8.GetByteCount(this.str);
        }

        public override string GetRowText(int row)
        {
            if (row == 0)
                return this.str;
            else
                return null;
        }
    }
}