using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DesignModeInCSharp.Strategy;

namespace DesignModeInCSharp
{
    public class ProbStrategy : Strategy.IStrategy
    {
        private Random random;
        private int prevHandValue = 0;
        private int currentHandValue = 0;
        private int[,] history = new int[3,3]
        {
            {1,1,1 },
            {1,1,1 },
            {1,1,1 }
        };//histroy[i][j]两局连续出i、j的概率密度
        public ProbStrategy(int seed) { this.random = new Random(seed); }
        public Hand NextHand()
        {
            int nextHand = this.random.Next(this.GetSum(currentHandValue));
            int handvalue = 0;
            //求和就是概率密度相加
            if (nextHand < this.history[currentHandValue, 0])
                handvalue = 0;
            else if (nextHand < this.history[currentHandValue, 0] + this.history[currentHandValue, 1])
                handvalue = 1;
            else
                handvalue = 2;
            prevHandValue = currentHandValue;
            currentHandValue = handvalue;
            return Hand.GetHand(currentHandValue);

        }

        public void Study(bool win)
        {
            if(win)
            {
                this.history[prevHandValue,currentHandValue]++;
            }
            else
            {
                //没有赢 如果我是对手相反就行了(对手比我小)
                history[prevHandValue,(currentHandValue + 1) % 3]++;//下一次我可以赢他
                history[prevHandValue, (currentHandValue + 2) % 3]++;
            }
        }
        /// <summary>
        /// 判断前一次出hv赢的总概率
        /// </summary>
        /// <param name="hv">号码</param>
        /// <returns></returns>
        private int GetSum(int hv)
        {
            int res = 0;
            for (int i = 0; i < 3; ++i)
                res += history[hv,i];
            return res;
        }
    }
}