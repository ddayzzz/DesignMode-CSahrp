using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModeInCSharp.Visitor
{
    class Test
    {
        public static void Main()
        {
            Directory root = new Directory("root");
            Directory usr = new Directory("usr");
            Directory home = new Directory("home");
            Directory home_root = new Directory("root");
            root.Add(usr);root.Add(home);
            home.Add(home_root);
            home_root.Add(new File("python.tar", 2000));
            home_root.Add(new File("gnu-gcc.tar", 2));
            home_root.Add(new File("gnu-g++.tar", 500));
            usr.Add(new File("gc.cpp", 50));
            root.Accept(new ListVisitor());
        }
        
    }
}
