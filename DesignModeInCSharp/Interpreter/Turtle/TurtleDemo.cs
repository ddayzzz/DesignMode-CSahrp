using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesignModeInCSharp.Interpreter.Language;
namespace DesignModeInCSharp.Interpreter.Turtle
{
    public partial class TurtleDemo : Form
    {
        private InterpreterFacade facade;
        public TurtleDemo()
        {
            InitializeComponent();
            facade = new InterpreterFacade(turtlePanel1);
            turtlePanel1.SetExecutor(facade);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cmd = textBox1.Text;
            facade.Parse(cmd);
            turtlePanel1.RePaint();
        }
    }
}
