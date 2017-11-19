using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignModeInCSharp.State
{
    public partial class SafeForm : Form, IContext
    {
        private IState state;
        private int hour=8;
        public SafeForm()
        {
            InitializeComponent();
            //从白天开始吧
            state = DayState.GetInstance();
            this.SetClock(hour);
            this.timer1.Enabled = true;//开始计时
        }

        public void CallSecurityCenter(string messages)
        {
            this.textBox_msg.AppendText("\r\n" + state.ToString() + " " + messages);
        }

        public void ChangeState(IState state)
        {
            this.state = state;
            this.textBox_msg.AppendText("\r\n" + "状态变更为" + state.ToString());
        }

        public void RecordLog(string messages)
        {
            this.textBox_msg.AppendText("\r\n记录信息：" + messages);
        }

        public void SetClock(int hour)
        {
            if (hour < 10)
                label_time.Text = "现在是0" + hour + ":00";
            else
                label_time.Text = "现在是" + hour + ":00";
            //通知状态
            this.state.DoClock(this, hour);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hour = (hour + 1) % 24;
            this.SetClock(hour);
        }

        private void button_use_Click(object sender, EventArgs e)
        {
            this.state.DoUse(this);
        }

        private void button_alarm_Click(object sender, EventArgs e)
        {
            this.state.DoAlarm(this);
        }

        private void button_phone_Click(object sender, EventArgs e)
        {
            this.state.DoUse(this);
        }

        private void button_end_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
