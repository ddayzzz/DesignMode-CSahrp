using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModeInCSharp.Mediator
{
    interface IColleague
    {
        void SetMediator(IMediator mediator);
        /// <summary>
        /// 根据仲裁者设置的结果（enabled）设置组件
        /// </summary>
        void SetColleagueEnable(bool enabled);
    }
}
