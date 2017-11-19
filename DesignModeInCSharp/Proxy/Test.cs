using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace DesignModeInCSharp.Proxy
{
    public class Test
    {
        public static void Main()
        {
            IPrintable p = new PrinterPoxy("Naive");
            //p.Print("你们啊！");
            //p.SetName("HK");
            //p.Print("连任吼不吼啊");
            Thread thread1 = new Thread(new ThreadStart(() => { p.Print("Naive"); }));
            Thread thread2 = new Thread(new ThreadStart(() => { p.SetName("Too young"); p.Print("Someytimes, Naive"); }));
            Thread thread3 = new Thread(new ThreadStart(() => { p.SetName("HK journalist"); p.Print("Run faster than western journalists"); }));
            thread1.Start();
            thread2.Start();
            thread3.Start();
            
        }
    }
}
