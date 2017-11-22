using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModeInCSharp.Interpreter.Language
{
    /// <summary>
    /// 使解释器更好用的类，Facade的角色Facade。用于整合各种类的使用，提供一个统一的接口
    /// </summary>
    public class InterpreterFacade:IExecutor
    {
        /// <summary>
        /// 一个工厂的类型
        /// </summary>
        private IExecutorFactory factory;
        private Context context;
        private Node progrsamNode;

        public InterpreterFacade(IExecutorFactory factory)
        {
            this.factory = factory;
        }

        public bool Parse(string text)
        {
            bool ok = true;
            try
            {
                this.context = new Context(text);
                this.context.SetExecutorFactory(factory);
                this.progrsamNode = new ProgramNode();
                progrsamNode.Parse(context);
                //System.Windows.Forms.MessageBox.Show(progrsamNode.ToString());
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.ToString());
                ok = false;
            }
            return ok;
        }

        public void Execute()
        {
            try
            {
                progrsamNode.Execute();
            }
            catch(Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
        }
    }
}
