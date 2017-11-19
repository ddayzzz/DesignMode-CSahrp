using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModeInCSharp.Observer
{
    public class Test
    {
        public static void Main()
        {
            SinaEmailSender sina = new SinaEmailSender();
            ShuMailBoxObserver shu = new ShuMailBoxObserver();
            QiangMailBoxObserver qiang = new QiangMailBoxObserver();
            sina.AddObserver(shu);
            sina.AddObserver(qiang);
            sina.SendEmail(new Email("2419940233@qq.com", "关于计算机1604班"));
            sina.SendEmail(new Email("333336999@qq.com", "关于人工智能协会"));
            Console.ReadKey();
        }
    }
}
