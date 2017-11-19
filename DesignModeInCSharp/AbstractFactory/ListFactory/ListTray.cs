using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModeInCSharp.AbstractFactory.ListFactory
{
    public class ListTray : Factory.Tray
    {
        public ListTray(string caption):base(caption)
        {

        }
        public override string MakeHtml()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<li>\n" + caption + "\n" + "<ul>\n");
            foreach(var item in this.tray)
            {
                sb.Append(item.MakeHtml());
            }
            sb.Append("</ul>\n</li>\n");
            return sb.ToString();
        }
    }
}
