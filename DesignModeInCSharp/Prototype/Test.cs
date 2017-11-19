using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModeInCSharp.Prototype
{
    public class Test
    {
        public static void Main()
        {
            Manager mgr = new Manager();
            UnderlinePen underline = new UnderlinePen('~');
            MessageBox mbox = new MessageBox('*');
            MessageBox sbox = new MessageBox('/');
            mgr.register("strong message", underline);
            mgr.register("warning box", mbox);
            mgr.register("slash box", sbox);
            Product p1 = mgr.Create("strong message");
            p1.Use("Hello world.");
            Product p2 = mgr.Create("warning box");
            p2.Use("Hello world");
            Product p3 = mgr.Create("slash box");
            p3.Use("Hello world");
        }
    }
}
