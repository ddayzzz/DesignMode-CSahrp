using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModeInCSharp.State
{
    public interface IState
    {
        /// <summary>
        /// 设置时间
        /// </summary>
        void DoClock(IContext context, int hour);
        /// <summary>
        /// 设置金库
        /// </summary>
        void DoUse(IContext context);
        /// <summary>
        /// 报警
        /// </summary>
        void DoAlarm(IContext context);
        /// <summary>
        /// 通话
        /// </summary>
        void DoPhone(IContext context);
    }
}
