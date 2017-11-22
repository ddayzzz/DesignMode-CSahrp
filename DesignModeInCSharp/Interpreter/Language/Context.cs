using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DesignModeInCSharp.Interpreter.Language
{
    public class Context
    {
        private string[] tokens;
        private int currentToken;
        /// <summary>
        /// 用于定义一个工厂
        /// </summary>
        private IExecutorFactory factory;
        public Context(string text)
        {
            tokens = text.Split(new char[]
            {
                '\n','\t','\f','\r', ' '
            });
            currentToken = -1;
            NextToken();//设置标记
        }

        /// <summary>
        /// 获取下一个标记
        /// </summary>
        public string NextToken()
        {
            if (tokens != null && currentToken < tokens.Length)
            {
                if (currentToken == -1)
                    return tokens[++currentToken];
                else
                    return tokens[currentToken++];

            }
                
            else
            {
                currentToken = -1;
                return null;
            }
            
        }

        /// <summary>
        /// 当前的标记
        /// </summary>
        public string CurrentToken()
        {
            if (currentToken != -1)
                return tokens[currentToken];
            else
                return null;
        }

        /// <summary>
        /// 跳过当前的标记
        /// </summary>
        public void SkipToken(string token)
        {
            if (!token.Equals(CurrentToken()))
            {
                throw new ParseException("Warning: " + token + " is expected, but " + currentToken + " found");
            }
            else
            {
                NextToken();
            }
        }

        /// <summary>
        /// 当前标记
        /// </summary>
        public int CurrentNumber()
        {
            int num = 0;
            try
            {
                num = int.Parse(CurrentToken());
            }
            catch(Exception e)
            {
                throw new ParseException(e.Message);
            }
            return num;
        }

        public void SetExecutorFactory(IExecutorFactory factory)
        {
            this.factory = factory;
        }

        public IExecutor CreateExecutor(string name)
        {
            return factory.CreateExecutor(name);
        }
    }
}
