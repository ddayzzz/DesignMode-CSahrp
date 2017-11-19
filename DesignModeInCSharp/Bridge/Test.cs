using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModeInCSharp.Bridge
{
    class A
    {
        public static readonly A[] s = new[] { new A(2.5) };//已经给static的常量分配空间了，第二次调用不会分配
        public A(int u)
        {
            Console.WriteLine("int");
        }
        public A(double u)
        {
            Console.WriteLine("double");
        }
    }
    public class Test
    {
        public static void Main()
        {
            A a = new A(5);
            //Display d1 = new Display(new StringDisplayImpl("Hello, China"));
            //Display d2 = new Display(new StringDisplayImpl("Hello, world!"));
            //CountDisplay d3 = new CountDisplay(new StringDisplayImpl("Hello, universe"));
            //d1.Show();
            //d2.Show();
            //d3.Show();
            //d3.MultiDisplay(5);
        }
    }
}
