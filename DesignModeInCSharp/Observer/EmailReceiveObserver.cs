using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModeInCSharp.Observer
{
    public interface EmailReceiveObserver
    {
        void Update(EmailSender sender);
    }
}
