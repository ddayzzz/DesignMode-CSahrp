using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModeInCSharp.Interpreter
{
    public class ProgramNode : Node
    {
        private Node commandListNode;
        /// <summary>
        /// 这是一个标记。类似于运算发+=、==等标记。词法分析是从文字中得到的标记，而语法解析则是根据标记推导语法树
        /// </summary>
        public override void Parse(Context context)
        {
            context.SkipToken("program");
            commandListNode = new CommandListNode();
            commandListNode.Parse(context);
        }

        public override string ToString()
        {
            return "[program " + commandListNode + "]";
        }
    }
}
