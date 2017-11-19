using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeInCSharp.Composite
{
    public class Test
    {
        public static void Main()
        {
            Directory root = new Directory("root");
            Directory bin = new Directory("bin");
            Directory tmp = new Directory("tmp");
            Directory usr = new Directory("usr");
            Directory shu = new Directory("shu");
            Directory liu = new Directory("liu");
            root.Add(bin);root.Add(tmp);root.Add(usr);
            bin.Add(new File("vi", 20));
            bin.Add(new File("latex", 20));
            usr.Add(shu);usr.Add(liu);
            shu.Add(new File("diary.txt", 50));
            shu.Add(new File("history.txt", 20));
            liu.Add(new File("gamer.cc", 20));
            root.PrintList(".");
        }
    }
}