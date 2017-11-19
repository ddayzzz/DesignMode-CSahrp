using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModeInCSharp.Builder
{
    class Testcs
    {
        public static void Main(string[] args)
        {
            if (args.Length != 1)
            {

            }
            else
            {
                if (args[0].Equals("plain"))
                {
                    TextBuilder textBuilder = new TextBuilder();
                    Director director = new Director(textBuilder);
                    director.Construct();
                    Console.WriteLine(textBuilder.GetResult());
                }
                else if(args[0].Equals("html"))
                {
                    HTMLBuilder hTMLBuilder = new HTMLBuilder();
                    Director director = new Director(hTMLBuilder);
                    director.Construct();
                    Console.WriteLine(hTMLBuilder.GetResult() + " 编写完成");
                }
                Console.ReadKey();
            }
        }
    }
}
