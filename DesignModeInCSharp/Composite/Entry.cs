using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModeInCSharp.Composite
{
    public abstract class Entry
    {
        
        public abstract string GetName();

        public abstract int GetSize();

        public abstract void PrintList(string prefix);

        public override string ToString()
        {
            return GetName() + "(" + GetSize() + ")";
        }

        public virtual void Add(Entry item)
        {
            throw new System.NotImplementedException("对象没有实现添加项目");
        }
    }
}
