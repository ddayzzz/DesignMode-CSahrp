using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModeInCSharp.Bridge
{
    /// <summary>
    /// 类的功能层次结构
    /// </summary>
    public class CountDisplay:Display
    {
        public CountDisplay(DisplayImpl impl) : base(impl) { }
        public void MultiDisplay(int times)
        {
            Open();
            for (int i = 0; i < times; ++i)
                Print();
            Close();
        }
    }
}
