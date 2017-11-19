using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModeInCSharp.Strategy
{
    public class Hand
    {
        public readonly static int HANDVALUE_STONE = 0;//石头的值
        public readonly static int HANDVALUE_SCISSOR = 1;//剪刀的值
        public readonly static int HANDVALUE_CLOTH = 2;//布
        public readonly static Hand[] hand = new Hand[]
        {
            new Hand(0),new Hand(1), new Hand(2)
        };//都是一个单例
        private int handvalue;//猜拳的手势的值
        private static readonly string[] name=new[] 
        {
            "石头","剪刀","布"
        };

        private Hand(int handvalue)
        {
            this.handvalue = handvalue;
        }

        public static Hand GetHand(int handvalue)
        {
            return hand[handvalue];
        }

        public bool IsStrongerThan(Hand h)
        {
            return this.Fight(h) == 1;//1是this胜利，0平局，-1this输了
        }

        public bool IsWeakerThan(Hand h)
        {
            return this.Fight(h) == -1;
        }

        private int Fight(Hand h)
        {
            if(this == h)
            {
                //相同
                return 0;
            }
            else
            {
                if ((this.handvalue + 1) == h.handvalue)
                    return 1;
                else
                    return -1;

            }
        }

        public override string ToString()
        {
            return name[handvalue];
        }
    }
}
