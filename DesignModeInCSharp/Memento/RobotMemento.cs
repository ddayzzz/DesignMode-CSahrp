using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModeInCSharp.Memento
{
    /// <summary>
    /// 定义一个备忘录，保存机器人的信息
    /// </summary>
    public class RobotMemento
    {

        public RobotMemento(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int X
        {
            get;
            private set;
        }

        public int Y
        {
            get;
            private set;
        }
    }
}
