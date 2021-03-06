﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModeInCSharp.Interpreter.Language
{
    class CommandNode : Node
    {
        private Node node;

        public override void Parse(Context context)
        {
            if (context.CurrentToken().Equals("repeat"))
            {
                node = new RepeatCommandNode();
                node.Parse(context);
            }
            else
            {
                node = new PrimitiveCommandNode();
                node.Parse(context);
            }
        }
        public override string ToString()
        {
            return node.ToString();
        }

        public override void Execute()
        {
            node.Execute();
        }
    }
}
