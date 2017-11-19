using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModeInCSharp.Observer
{
    public sealed class Email
    {
        public string From { get; set; }
        public string Title { get; set; }
        public Email(string from, string title)
        {
            this.From = from;
            this.Title = title;
        }
    }
}
