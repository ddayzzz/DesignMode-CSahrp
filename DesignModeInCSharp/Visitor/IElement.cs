using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeInCSharp.Visitor
{
    public interface IElement
    {
        void Accept(Visitor visitor);
    }
}