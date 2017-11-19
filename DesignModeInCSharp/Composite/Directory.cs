using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DesignModeInCSharp.Composite;
namespace DesignModeInCSharp.Composite
{
    public class Directory : Composite.Entry
    {
        private string name;
        private List<Entry> items;

        public Directory(string name)
        {
            this.name = name;
            this.items = new List<Entry>();
        }

        public override string GetName()
        {
            return this.name;
        }

        public override int GetSize()
        {
            int size = 0;
            for (int i = 0; i < this.items.Count; ++i)
                size += this.items[i].GetSize();
            return size;
        }

        public override sealed void Add(Entry item)
        {
            this.items.Add(item);
        }

        public override void PrintList(string prefix)
        {
            string dir = prefix + "/" + name;
            Console.WriteLine(dir + "(" + this.GetSize() + ")");
            foreach(var item in items)
            {
                item.PrintList(dir);
            }
        }
    }
}