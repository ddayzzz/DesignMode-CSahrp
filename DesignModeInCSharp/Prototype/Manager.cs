using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModeInCSharp.Prototype
{
    public class Manager
    {
        private Dictionary<string, Product> showcase = new Dictionary<string, Product>();
        public void register(string name, Product proto)
        {
            showcase.Add(name, proto);//添加关键字为name的原型
        }
        public Product Create(string protoname)
        {
            Product p = showcase[protoname];
            return (Product)p.Clone();
        }
    }
}
