using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModeInCSharp.Proxy
{
    public class PrinterPoxy : IPrintable
    {
        private static System.Threading.Mutex mutex = new System.Threading.Mutex();
        private string name;
        /// <summary>
        /// 实际的打印机对象
        /// </summary>
        private IPrintable real;

        public PrinterPoxy(string name)
        {
            this.name = name;
        }

        public string GetName() => name;

        public void Print(string str)
        {
            realize();
            real.Print(str);
        }

        public void SetName(string name)
        {
            lock (mutex)
            {
                if (real != null)
                {
                    real.SetName(name);
                }
                this.name = name;
            }
        }

        private void realize()
        {
            lock (mutex)
            {
                if (real == null)
                    real = new Printer(name);
            }
        }
    }
}
