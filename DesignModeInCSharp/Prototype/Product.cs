using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModeInCSharp.Prototype
{
    public interface Product:ICloneable
    {
        void Use(string s);
    }
}
