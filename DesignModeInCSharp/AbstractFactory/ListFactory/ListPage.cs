using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModeInCSharp.AbstractFactory.ListFactory
{
    public class ListPage : Factory.Page
    {
        public ListPage(string title, string author):base(title, author)
        {

        }
        public override string MakeHtml()
        {
            StringBuilder buffer = new StringBuilder();
            buffer.Append("<html><head><title>" + this.title + "</title></head>\n");
            buffer.Append("<body>\n<h1>" + this.title + "</h1>\n");
            buffer.Append("<ul>\n");//content默认是一些无序列表
            foreach(var item in this.content)
            {
                buffer.Append(item.MakeHtml());
            }
            buffer.Append("</ul>\n<hr><address>" + author + "</address></body></html>\n");
            return buffer.ToString();
        }
    }
}
