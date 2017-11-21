using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModeInCSharp.Interpreter
{
    public abstract class Node
    {
        /// <summary>
        /// 解析
        /// </summary>
        public abstract void Parse(Context context);
    }
}
