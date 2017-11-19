using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModeInCSharp.Bridge
{
    /// <summary>
    /// 类的实现结构
    /// </summary>
    public class StringDisplayImpl : DisplayImpl
    {
        private string str;
        private int width;
        public StringDisplayImpl(string str)
        {
            this.str = str;
            this.width = Encoding.UTF8.GetByteCount(str);
        }
        private void PrintLine()
        {
            Console.Write("+");
            for (int i = 0; i < width; ++i)
                Console.Write("-");
            Console.WriteLine("+");
        }
        public override void RawClose()
        {
            PrintLine();
        }

        public override void RawOpen()
        {
            this.PrintLine();
            
        }

        public override void RawPrint()
        {
            Console.WriteLine("|" + str + "|");
        }
    }
}
