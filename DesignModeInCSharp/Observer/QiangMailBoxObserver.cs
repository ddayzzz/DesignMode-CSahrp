using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModeInCSharp.Observer
{
    public class QiangMailBoxObserver : EmailReceiveObserver
    {
        public void Update(EmailSender sender)
        {
            if (sender.GetEmail() != null)
            {
                Email email = sender.GetEmail();
                Console.WriteLine("Qiang的邮箱收到：[发送者服务商]:" + sender.SenderName + "[来自]：" + email.From + ", [标题]" + email.Title);
            }
        }
    }
}
