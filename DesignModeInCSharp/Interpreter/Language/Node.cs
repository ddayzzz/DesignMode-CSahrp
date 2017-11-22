using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModeInCSharp.Interpreter.Language
{
    public abstract class Node : IExecutor
    {
        /// <summary>
        /// 执行对应的命令
        /// </summary>
        public abstract void Execute();
        /// <summary>
        /// 解析
        /// </summary>
        public abstract void Parse(Context context);
    }
}
