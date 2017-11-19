using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModeInCSharp.Mediator
{
    public interface IMediator
    {
        /// <summary>
        /// 创建一个用于仲裁的组件
        /// </summary>
        void CreateCollegues();
        /// <summary>
        /// 由仲裁者决定修改组件
        /// </summary>
        void ColleagueChanged();
    }
}
