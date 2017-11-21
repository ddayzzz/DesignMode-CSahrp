using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace DesignModeInCSharp.Command
{
    class DrawPanel : Panel, IDrawable
    {
        private int radius = 1;
        private Color color = Color.Red;
        private Graphics graph;
        public DrawPanel()
        {
        }
        public Graphics Draw(int x, int y)
        {
            //绘制图形
            Graphics g = this.CreateGraphics();
            //MessageBox.Show(g.GetHashCode().ToString());
            Pen pen = new Pen(color);
            g.DrawEllipse(pen, x - radius, y - radius, radius * 2, radius * 2);
            return g;
        }
    }
}
