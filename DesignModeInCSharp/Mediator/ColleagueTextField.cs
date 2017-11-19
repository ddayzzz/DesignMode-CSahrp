using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DesignModeInCSharp.Mediator
{
    public class ColleagueTextField : TextBox, IColleague
    {
        private IMediator mediator;
        public ColleagueTextField()
        {
            this.TextChanged += new EventHandler(this.TextChanged_SendToMediator); //注册一个通知仲裁者的事件处理程序
        }
        public void SetColleagueEnable(bool enabled)
        {
            this.Enabled = enabled;
        }

        public void SetMediator(IMediator mediator)
        {
            this.mediator = mediator;
        }
        private void TextChanged_SendToMediator(object sender, EventArgs e)
        {
            if(this.mediator !=null)
            {
                //定义了仲裁者
                this.mediator.ColleagueChanged();
            }
        }
    }
}
