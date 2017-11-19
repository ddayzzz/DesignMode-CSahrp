using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModeInCSharp.Dectorator
{
    public abstract class Display
    {
        /// <summary>
        /// 获取横向字符数
        /// </summary>
        /// <returns>返回字符的个数</returns>
        public abstract int GetColumns();

        /// <summary>
        /// 获取纵向行数
        /// </summary>
        /// <returns>长度</returns>
        public abstract int GetRows();

        /// <summary>
        /// 获取row行的字符串
        /// </summary>
        /// <returns>字符串</returns>
        public abstract string GetRowText(int row);

        /// <summary>
        /// 显示字符串
        /// </summary>
        public void Show(System.IO.TextWriter stdout)
        {
            for (int i = 0; i < this.GetRows(); ++i)
                stdout.WriteLine(this.GetRowText(i));
        }
    }
}
