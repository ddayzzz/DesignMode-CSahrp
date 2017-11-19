using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModeInCSharp.Visitor
{
    public class File : Entry
    {

        public override void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }
        public File(string name, int size)
        {
            this.Name = name;
            this.Size = size;
        }
        public override int Size { get; }
        public override string Name { get; }
    }
}
