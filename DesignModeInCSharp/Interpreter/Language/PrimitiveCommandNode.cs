using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModeInCSharp.Interpreter.Language
{
    class PrimitiveCommandNode : Node
    {
        private string name;
        private IExecutor executor;
        public override void Parse(Context context)
        {
            name = context.CurrentToken();
            context.SkipToken(name);
            if (!name.Equals("go") && !name.Equals("right") && !name.Equals("left"))
                throw new ParseException(name + " is undefined!");
            executor = context.CreateExecutor(name);//根据实际命令的名称获取执行器
        }
        public override string ToString()
        {
            return name.ToString();
        }

        public override void Execute()
        {
            if (executor == null)
                throw new ExecuteException("name :" + name + " is not defined");
            executor.Execute();
        }
    }
}
