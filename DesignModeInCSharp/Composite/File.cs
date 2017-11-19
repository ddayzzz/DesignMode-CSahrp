using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeInCSharp.Composite
{
    public class File : Composite.Entry
    {
        private string name;
        private int size;

        public File(string name, int size)
        {
            this.name = name;
            this.size = size;
        }

        public override string GetName()
        {
            return this.name;
        }

        public override int GetSize()
        {
            return this.size;
        }

        public override void PrintList(string prefix)
        {
            Console.WriteLine(prefix + "/" + this.name);
        }
    }
}