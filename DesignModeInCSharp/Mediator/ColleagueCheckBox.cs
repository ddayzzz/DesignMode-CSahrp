using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DesignModeInCSharp.Mediator
{
    public class ColleagueCheckBox : CheckBox, IColleague
    {
        private IMediator mediator;
        private void CheckStateChanged_SendToMediator(object sender, EventArgs e)
        {
            if(this.mediator !=null)
            {
                this.mediator.ColleagueChanged();
            }
        }
        public ColleagueCheckBox()
        {
            this.CheckStateChanged += new EventHandler(CheckStateChanged_SendToMediator);
        }
        public void SetColleagueEnable(bool enabled)
        {
            this.Enabled = enabled;
        }

        public void SetMediator(IMediator mediator)
        {
            this.mediator = mediator;
        }
    }
}
