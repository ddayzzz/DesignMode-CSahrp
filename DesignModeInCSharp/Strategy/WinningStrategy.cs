using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DesignModeInCSharp.Strategy;

namespace DesignModeInCSharp
{
    public class WinningStrategy : Strategy.IStrategy
    {
        private Random random;
        private bool won = false;//先前赢了？
        private Hand prevHand;//先前的出拳
        public WinningStrategy(int seed)
        {
            this.random = new Random(seed);
        }
        public Hand NextHand()
        {
            if (!this.won)
                this.prevHand = Hand.GetHand(random.Next(0, 3));
            return this.prevHand;
        }
        /// <summary>
        /// 是否赢了
        /// </summary>
        /// <param name="win">赋值给上次是否赢</param>
        public void Study(bool win)
        {
            won = win;
        }
    }
}