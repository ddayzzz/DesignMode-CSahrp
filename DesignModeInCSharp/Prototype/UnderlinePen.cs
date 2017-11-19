using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModeInCSharp.Prototype
{
    public class UnderlinePen : Product
    {
        private char ulchar;
        public UnderlinePen(char ulchar)
        {
            this.ulchar = ulchar;
        }
        public void Use(string s)
        {
            int length = Encoding.UTF8.GetBytes(s).Length;
            Console.WriteLine("\"" + s + "\"");
            Console.Write(" ");
            for (int i = 0; i < length; ++i)
            {
                Console.Write(ulchar);
            }
            Console.WriteLine(" ");
        }
        public object Clone()
        {
            Product p = null;
            try
            {
                p = new UnderlinePen(this.ulchar);
            }
            catch (NotImplementedException e)
            {
                Console.WriteLine(e.Message);
            }
            return p;
        }
    }
}
