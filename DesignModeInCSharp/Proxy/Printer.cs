using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignModeInCSharp.Proxy
{
    public class Printer : IPrintable
    {
        private string name;
        public Printer(string name)
        {
            this.name = name;
            heavyTask("Printer实例化中(" + name + ")");
        }
        public string GetName()
        {
            return name;
        }

        public void Print(string str)
        {
            Console.WriteLine("===" + name + "===");
            Console.WriteLine(str);
        }

        public void SetName(string name)
        {
            this.name = name;
        }
        private void heavyTask(string str)
        {
            Console.WriteLine(str);
            Thread.Sleep(5000);
        }
    }
}
