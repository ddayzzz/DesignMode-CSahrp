using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignModeInCSharp.Command
{
    public partial class DrawForm : Form
    {
        private MacroCommand history = new MacroCommand();
        public DrawForm()
        {
            InitializeComponent();
        }

        private void DrawForm_MouseDown(object sender, MouseEventArgs e)
        {
            var cmd = new DrawCommand(this.drawPanel1, e.Location);
            history.Append(cmd);
            cmd.Execute();
        }

        private void drawPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            this.Text = "up";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            history.Reset();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            history.Undo();
        }
    }
}
