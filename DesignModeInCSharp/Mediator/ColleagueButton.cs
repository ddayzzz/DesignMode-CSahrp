using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DesignModeInCSharp.Mediator
{
    public class ColleagueButton : Button, IColleague
    {
        private IMediator mediator;
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
