using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModeInCSharp.Interpreter.Language
{
    class ExecuteException:Exception
    {
        public ExecuteException(string msg):base(msg)
        {

        }
    }
}
