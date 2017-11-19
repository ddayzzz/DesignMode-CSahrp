using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModeInCSharp.AbstractFactory.Factory
{
    public abstract class Tray:Item
    {
        protected List<Item> tray = new List<Item>();
        public Tray(string caption) : base(caption) { }
        public void Add(Item item)
        {
            this.tray.Add(item);
        }
    }
}
