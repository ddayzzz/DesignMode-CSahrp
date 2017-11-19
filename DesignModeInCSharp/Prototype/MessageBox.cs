using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModeInCSharp.Prototype
{
    public class MessageBox:Product
    {
        private char decochar;
        public MessageBox(char decochar)
        {
            this.decochar = decochar;
        }
        public void Use(string s)
        {
            int length = Encoding.UTF8.GetBytes(s).Length;
            for (int i = 0; i < length + 4;++i)
            {
                Console.Write(decochar);
            }
            Console.WriteLine(" ");
            Console.WriteLine(decochar + " " + s + " " + decochar);
        }
        public object Clone()
        {
            Product p = null;
            try
            {
                p = new MessageBox(this.decochar);
            }
            catch(NotImplementedException e)
            {
                Console.WriteLine(e.Message);
            }
            return p;
        }
    }
}
