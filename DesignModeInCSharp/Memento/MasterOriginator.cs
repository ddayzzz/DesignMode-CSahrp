using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModeInCSharp.Memento
{
    /// <summary>
    /// 这个定义的是机器的主人，可以创建备忘录保存信息
    /// </summary>
    class MasterOriginator
    {
        public MasterOriginator(int x, int y)
        {
            X = x;
            Y = y;
            Console.WriteLine($"Start:X={x}, Y={y}");
        }

        /// <summary>
        /// 当前的X坐标
        /// </summary>
        public int X
        {
            get;
            set;
        }

        /// <summary>
        /// 当前的Y坐标
        /// </summary>
        public int Y
        {
            get;
            set;
        }

        /// <summary>
        /// 创建一个备份
        /// </summary>
        public RobotMemento CreateMemento()
        {
            Console.WriteLine($"CreateMemento:X={this.X}, Y={this.Y}");
            return new RobotMemento(X, Y);
        }

        /// <summary>
        /// 从一个备份中恢复一个状态
        /// </summary>
        public void RestoreMemento(RobotMemento memento)
        {
            this.X = memento.X;
            this.Y = memento.Y;
            Console.WriteLine($"Restore:X={this.X}, Y={this.Y}");
        }

        public void Place(int x, int y)
        {
            this.X = x;
            this.Y = y;
            Console.WriteLine($"MoveTo:X={x}, Y={y}");
        }
    }
}
