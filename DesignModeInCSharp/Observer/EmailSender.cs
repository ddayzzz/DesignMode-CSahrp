using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModeInCSharp.Observer
{
    public abstract class EmailSender
    {
        private List<EmailReceiveObserver> observers;
        /// <summary>
        /// 发送者的名称
        /// </summary>
        public string SenderName { get; private set; }
        /// <summary>
        /// 构造函数
        /// </summary>
        public EmailSender(string senderName)
        {
            observers = new List<EmailReceiveObserver>();
            this.SenderName = senderName;
        }

        /// <summary>
        /// 添加观察者
        /// </summary>
        public void AddObserver(EmailReceiveObserver observer)
        {
            if (this.observers != null)
            {
                observers.Add(observer);
            }
        }

        /// <summary>
        /// 移除观察者
        /// </summary>
        public void DeleteObserver(EmailReceiveObserver observer)
        {
            if (this.observers != null)
            {
                this.observers.Remove(observer);
            }
        }

        /// <summary>
        /// 通知所有的观察者
        /// </summary>
        public void NotifyObservers()
        {
            if(observers !=null)
            {
                foreach(var item in observers)
                {
                    item.Update(this);
                }
            }
        }

        /// <summary>
        /// 获取邮件的内容
        /// </summary>
        public abstract Email GetEmail();

        /// <summary>
        /// 发送邮件
        /// </summary>
        public abstract void SendEmail(Email email);
    }
}
