using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DesignModeInCSharp.AbstractFactory.Factory
{
    public abstract class Page
    {
        protected string title;
        protected string author;
        protected List<Item> content = new List<Item>();
        public Page(string title, string author)
        {
            this.title = title;
            this.author = author;
        }
        public void Add(Item item)
        {
            this.content.Add(item);
        }
        public void Output()
        {
            try
            {
                string filename = this.title + ".html";
                StreamWriter writer = new StreamWriter(new FileStream(filename, FileMode.Create));
                writer.Write(this.MakeHtml());
                writer.Close();
                Console.WriteLine(filename + " 编写完成");
            }catch(Exception e)
            {
                Console.WriteLine("异常:" + e.Message);
            }
        }
        public abstract string MakeHtml();
    }
}
