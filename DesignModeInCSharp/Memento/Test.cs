using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModeInCSharp.Memento
{
    class Test
    {
        public static void Main()
        {
            MasterOriginator master = new MasterOriginator(0, 0);
            List<RobotMemento> list = new List<RobotMemento>();
            while(true)
            {
                ConsoleKeyInfo key = Console.ReadKey(false);
                switch(key.Key)
                {
                    case ConsoleKey.Escape:
                        //保存
                        list.Add(master.CreateMemento());
                        break;
                    case ConsoleKey.UpArrow:
                        master.Place(master.X, master.Y - 1);
                        break;
                    case ConsoleKey.DownArrow:
                        master.Place(master.X, master.Y + 1);
                        break;
                    case ConsoleKey.RightArrow:
                        master.Place(master.X + 1, master.Y);
                        break;
                    case ConsoleKey.LeftArrow:
                        master.Place(master.X - 1, master.Y);
                        break;
                    case ConsoleKey.B:
                        Console.WriteLine("请选择一个恢复的坐标编号【1~" + list.Count + "】：");
                        int i = 0;
                        list.ForEach((RobotMemento memento) => { Console.WriteLine($"{i} X={memento.X}, Y={memento.Y}"); });
                        int id = Console.Read();
                        master.RestoreMemento(list[i]);
                        break;
                }
            }
        }
        
    }
}
