using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeInCSharp.Visitor
{
    public abstract class Entry : IElement
    {
        public abstract string Name { get; }
        public abstract int Size { get; }

        public virtual void Add(Entry entry)
        {
            throw new System.NotImplementedException();
        }

        public virtual IEnumerator<Entry> Iterator()
        {
            throw new System.NotImplementedException("类型错误");
        }

        public override string ToString()
        {
            return this.Name + " (" + Size + ")";
        }
        public abstract void Accept(Visitor visitor);
    }
}