using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModeInCSharp.Interpreter.Language
{
    /// <summary>
    /// 循环体的定义
    /// </summary>
    class RepeatCommandNode : Node
    {
        /// <summary>
        /// 定义计数器
        /// </summary>
        private int number;
        private Node commandListNode;

        public override void Parse(Context context)
        {
            context.SkipToken("repeat");
            number = context.CurrentNumber();
            context.NextToken();
            commandListNode = new CommandListNode();
            commandListNode.Parse(context);
        }
        public override string ToString()
        {
            return "[repeat " + number + " " + commandListNode + "]";
        }

        public override void Execute()
        {
            for (int i = 0; i < number; ++i)
                commandListNode.Execute();
        }
    }
}
