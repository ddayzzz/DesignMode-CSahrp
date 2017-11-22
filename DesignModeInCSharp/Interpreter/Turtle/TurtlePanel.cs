using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using DesignModeInCSharp.Interpreter.Language;
namespace DesignModeInCSharp.Interpreter.Turtle
{
    public class TurtlePanel : Panel, IExecutorFactory
    {
        private static readonly int UNIT_LENGTH = 30;//向前走的距离
        private enum DIRECTION
        {
            UP=0, RIGHT=3, DOWN=6, LEFT=9
        };
        private static readonly int RELATIVE_DIRECTION_LEFT = -3;//相对上一次的方向
        private static readonly int RELATIVE_DIRECTION_RIGHT = 3;
        private static readonly int RADIUS = 3;//半径
        private DIRECTION direction;//保存的方向，默认向上
        private Point position= new Point();//位置
        private IExecutor executor;//执行器
        public IExecutor CreateExecutor(string name)
        {
            if (name.Equals("go"))
                return new GoExecutor(this);
            else if (name.Equals("left"))
                return new DirectionExecutor(this, RELATIVE_DIRECTION_LEFT);
            else if (name.Equals("right"))
                return new DirectionExecutor(this, RELATIVE_DIRECTION_RIGHT);
            else
                return null;
        }

        public TurtlePanel()
        {
            Initialize();
        }


        public void SetExecutor(IExecutor executor)
        {
            this.executor = executor;
        }
        public void SetRelativeDirection(int targetDirection)
        {
            if(targetDirection < 0)
            {
                targetDirection = 12 - (-targetDirection) % 12;//由于向左不符合标准的顺时针的形式，所以需要相减
            }
            else
            {
                targetDirection = targetDirection % 12;
            }
            this.direction = (DIRECTION)targetDirection;
        }
        private void Go(int length)
        {
            int nx = position.X;
            int ny = position.Y;
            switch(direction)
            {
                case DIRECTION.UP:
                    ny -= length;
                    break;
                case DIRECTION.DOWN:
                    ny += length;
                    break;
                case DIRECTION.LEFT:
                    nx -= length;
                    break;
                case DIRECTION.RIGHT:
                    nx += length;
                    break;
                default:
                    break;
            }
            Point targetPos = new Point(nx, ny);
            Graphics g = this.CreateGraphics();
            if (g != null)
            {
                g.DrawLine(new Pen(Color.Red), position, targetPos);
                g.FillEllipse(new SolidBrush(Color.Red), nx - RADIUS, ny - RADIUS, RADIUS * 2 + 1, RADIUS * 2 + 1);
            }
            position = targetPos;
        }

        public void Initialize()
        {
            this.position.X = this.Size.Width / 2;
            position.Y = Size.Height / 2;
            direction = DIRECTION.UP;
            Graphics g = this.CreateGraphics();
            if(g !=null)
            {
                g.Clear(Color.FromName("Control"));
            }
        }

        public void RePaint()
        {
            Initialize();
            try
            {
                if(executor !=null)
                {
                    executor.Execute();
                }

            }catch(Exception e)
            {

            }
        }
        //定义内部类
        abstract class TurtleExecutor : IExecutor
        {
            protected TurtlePanel panel;
            public TurtleExecutor(TurtlePanel panel) { this.panel = panel; }
            public abstract void Execute();
        }
        class GoExecutor : TurtleExecutor
        {
            public GoExecutor(TurtlePanel panel) : base(panel) { }
            public override void Execute()
            {
                panel.Go(TurtlePanel.UNIT_LENGTH);
            }
        }
        class DirectionExecutor : TurtleExecutor
        {
            private int relativeDirection;
            public DirectionExecutor(TurtlePanel panel, int relativeDirection):base(panel) { this.relativeDirection = relativeDirection; }
            public override void Execute()
            {
                panel.SetRelativeDirection(relativeDirection + (int)panel.direction);
            }
        }
    }
}
