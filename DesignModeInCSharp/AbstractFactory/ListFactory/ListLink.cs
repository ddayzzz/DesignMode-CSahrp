using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModeInCSharp.AbstractFactory.ListFactory
{
    public class ListLink:Factory.Link
    {
        public ListLink(string caption, string url):base(caption, url)
        {
            
        }

        public override string MakeHtml()
        {
            return "<li><a href=\"" + url + "\">" + caption + "</a></li>\n";
        }
    }
}
