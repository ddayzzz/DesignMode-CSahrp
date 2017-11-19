using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModeInCSharp.Observer
{
    class SinaEmailSender : EmailSender
    {
        private Email currentEmail = null;
        public SinaEmailSender() : base("新浪邮箱")
        {

        }
        public override Email GetEmail()
        {
            return currentEmail;
        }
        public override void SendEmail(Email email)
        {
            this.currentEmail = email;
            this.NotifyObservers();
        }
    }
    
}
