using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModeInCSharp.Proxy
{
    public interface IPrintable
    {
        string GetName();
        void SetName(string name);
        void Print(string str);
    }
}
