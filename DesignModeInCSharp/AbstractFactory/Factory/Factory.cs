using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModeInCSharp.AbstractFactory.Factory
{
    public abstract class Factory
    {
       public static Factory GetFactory(string classname)
        {
            Factory factory = null;
            try
            {
                Type type = Type.GetType(classname);
                factory = (Factory)System.Activator.CreateInstance(type);//利用反射创建对象
            }
            catch(Exception e)
            {
                Console.WriteLine("错误：" + e.Message);
            }
            return factory;
        }
        public abstract Link CreateLink(string caption, string url);
        public abstract Tray CreateTray(string caption);
        public abstract Page CreatePage(string title, string author);
    }
}
