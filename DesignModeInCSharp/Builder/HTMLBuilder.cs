using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace DesignModeInCSharp.Builder
{
    public class HTMLBuilder:Builder
    {
        private string filename;
        private StreamWriter writer;

        public override void Close()
        {
            writer.WriteLine("</body></html>");
            this.writer.Close();
        }

        public override void MakeItem(string[] items)
        {
            foreach(var item in items)
            {
                this.MakeString(item);
            }
        }

        public override void MakeString(string str)
        {
            writer.WriteLine("<p>" + str + "</p>");
        }

        public override void MakeTitle(string title)
        {
            filename = title + ".html";
            try
            {
                writer = new System.IO.StreamWriter(File.OpenWrite(filename));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            writer.WriteLine("<html><head><title>" + title + "</title></head><body>");
            writer.WriteLine("<h1>" + title + "</h1>");
        }

        public string GetResult()
        {
            return filename;
        }
    }
}
