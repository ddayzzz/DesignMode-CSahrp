using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModeInCSharp.Command
{
    class DrawCommand : ICommand
    {
        protected IDrawable drawable;
        private Point position;
        private Graphics graphics;
        private readonly static System.Drawing.Color resetColor = Color.FromName("Control");
        public DrawCommand(IDrawable drawable, Point position)
        {
            this.drawable = drawable;
            this.position = position;
        }

        public void Execute()
        {
            graphics = drawable.Draw(position.X, position.Y);
        }

        public void Reset()
        {

            this.graphics.Clear(resetColor);
        }
    }
}
