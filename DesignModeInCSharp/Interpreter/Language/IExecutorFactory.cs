using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModeInCSharp.Interpreter.Language
{
    /// <summary>
    /// 生成基本命令的接口。Factory模式的Factory
    /// </summary>
    public interface IExecutorFactory
    {
        IExecutor CreateExecutor(string name);
    }
}
