using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignModeInCSharp.Mediator
{
    public partial class LoginForm : Form, IMediator
    {
        public LoginForm()
        {
            InitializeComponent();
            //添加仲裁者
            this.colleagueButton_cancel.SetMediator(this);
            this.colleagueButton_ok.SetMediator(this);
            this.colleagueCheckBox1.SetMediator(this);
            this.colleagueCheckBox2.SetMediator(this);
            this.colleagueTextField_password.SetMediator(this);
            this.colleagueTextField_username.SetMediator(this);
        }
        private void userpasswordChnaged()
        {
            if(colleagueTextField_username.Text.Length > 0)
            {
                colleagueTextField_password.SetColleagueEnable(true);
                if(colleagueTextField_password.Text.Length > 0)
                {
                    this.colleagueButton_ok.SetColleagueEnable(true);
                }
                else
                {
                    this.colleagueButton_ok.SetColleagueEnable(false);
                }
            }
            else
            {
                this.colleagueButton_ok.SetColleagueEnable(false);
                colleagueTextField_password.SetColleagueEnable(false);
            }
        }
        public void ColleagueChanged()
        {
            //检查组件的状态
            if(colleagueCheckBox1.CheckState == CheckState.Checked)
            {
                //游客状态
                colleagueTextField_password.SetColleagueEnable(false);
                colleagueTextField_username.SetColleagueEnable(false);
                colleagueButton_ok.SetColleagueEnable(true);
            }
            else
            {
                colleagueTextField_username.SetColleagueEnable(true);
                userpasswordChnaged();
            }
        }

        public void CreateCollegues()
        {
            throw new NotImplementedException();
        }
    }
}
