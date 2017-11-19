using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModeInCSharp.Dectorator
{
    public class Test
    {
        public static void Main()
        {
            Display b1 = new StringDisplay("Hello world!");
            Display b2 = new HTMLFormater(b1);
            b1.Show(Console.Out);
            Display b3 =
                new PlainXMLFormater(
                new HTMLFormater(
                    new HTMLFormater(
                        new StringDisplay("你好啊。"))));
            b3.Show(Console.Out);
            object g = 25;
        }
    }
}
