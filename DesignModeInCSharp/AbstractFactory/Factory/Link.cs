using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModeInCSharp.AbstractFactory.Factory
{
    /// <summary>
    /// 实例化的子类：html中a标签
    /// </summary>
    public abstract class Link : Item
    {
        protected string url;
        public Link(string caption, string url):base(caption)
        {
            this.url = url;
        }
    }
}
