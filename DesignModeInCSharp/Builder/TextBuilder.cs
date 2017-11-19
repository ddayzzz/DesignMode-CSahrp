using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModeInCSharp.Builder
{
    public class TextBuilder:Builder
    {
        private StringBuilder buffer = new StringBuilder();

        public override void Close()
        {
            buffer.Append("==================================\n");
        }

        public override void MakeItem(string[] items)
        {
            for (int i = 0; i < items.Length; ++i)
                buffer.Append("\t•" + items[i] + '\n');
            buffer.Append("\n");
        }

        public override void MakeString(string str)
        {
            buffer.Append('■' + str + "\n");
            buffer.Append("\n");
        }

        public override void MakeTitle(string title)
        {
            buffer.Append("==================================\n <" + title + ">\n");
        }
        public string GetResult()
        {
            return this.buffer.ToString();
        }
    }
}
