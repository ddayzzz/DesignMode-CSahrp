using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModeInCSharp.State
{
    /// <summary>
    /// 表示晚上的状态
    /// </summary>
    public class NightState : IState
    {
        private static NightState singleton = new NightState();
        public static NightState GetInstance() => singleton;
        public void DoAlarm(IContext context)
        {
            context.CallSecurityCenter("按下警铃（晚上）");
        }

        public void DoClock(IContext context, int hour)
        {
            if (hour >= 9 && hour < 17)//非晚上时间
                context.ChangeState(DayState.GetInstance());
        }

        public void DoPhone(IContext context)
        {
            context.CallSecurityCenter("晚上通话录音");
        }

        public void DoUse(IContext context)
        {
            context.RecordLog("紧急：晚上使用金库");
        }
        public override string ToString()
        {
            return "[晚上]";
        }
    }
}
