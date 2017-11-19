using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModeInCSharp.Visitor
{
    public class Directory : Entry
    {
        private List<Entry> items;
        public override string Name { get; }
        public override int Size {
            get
            {
                int sz = 0;
                foreach (var item in this.items)
                    sz += item.Size;
                return sz;
            }
        }
        public Directory(string name)
        {
            this.items = new List<Entry>();
            this.Name = name;
        }
        public override void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }

        public override void Add(Entry item)
        {
            this.items.Add(item);
        }

        public override IEnumerator<Entry> Iterator()
        {
            return this.items.GetEnumerator();
        }
    }
}
