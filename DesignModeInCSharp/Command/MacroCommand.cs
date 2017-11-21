using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModeInCSharp.Command
{
    /// <summary>
    /// 实现了一组的命令
    /// </summary>
    class MacroCommand : ICommand
    {
        private Stack<ICommand> commands;
        public MacroCommand()
        {
            commands = new Stack<ICommand>();
        }

        /// <summary>
        /// 执行栈中所有的命令
        /// </summary>
        public void Execute()
        {
            foreach (var cmd in commands)
            {
                cmd.Execute();
            }
        }

        /// <summary>
        /// 附加一条命令到栈顶
        /// </summary>
        public void Append(ICommand command)
        {
            commands.Push(command);
        }

        /// <summary>
        /// 删除栈顶中的命令。这是一个伪删除。因为所有的Graphics都砸i一个容器中，清空一个就会清空另一个
        /// </summary>
        public void Undo()
        {
            if (commands.Count > 0)
            {
                var cmd = commands.Pop();
                cmd.Reset();
                Execute();
            }
        }

        public void Reset()
        {
            foreach (var cmd in commands)
            {
                cmd.Reset();
            }
            commands.Clear();
        }
    }
}
