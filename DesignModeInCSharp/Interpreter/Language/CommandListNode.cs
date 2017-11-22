using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModeInCSharp.Interpreter.Language
{
    class CommandListNode : Node
    {
        private List<Node> list=new List<Node>();

        public override void Parse(Context context)
        {
            while (true)
            {
                if (context.CurrentToken() == null)
                {
                    throw new ParseException("Missing end");
                }
                else if (context.CurrentToken().Equals("end"))
                {
                    context.SkipToken("end");
                    break;
                }
                else
                {
                    Node node = new CommandNode();
                    node.Parse(context);
                    list.Add(node);
                }
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("[ ");
            foreach(var node in list)
            {
                sb.Append(node.ToString() + " ");
            }
            return sb.Append("]").ToString();
        }

        public override void Execute()
        {
            foreach(var cmd in list)
            {
                cmd.Execute();
            }
        }
    }
}
