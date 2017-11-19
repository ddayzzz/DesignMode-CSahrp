using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignModeInCSharp
{
    using Strategy;
    public class Player
    {
        private string name;
        private IStrategy strategy;
        private int wincount;
        private int losecount;
        private int gamecount;

        public Player(string name, IStrategy strategy)
        {
            this.name = name;
            this.strategy = strategy;
        }

        public Strategy.Hand NextHand()
        {
            return this.strategy.NextHand();
        }

        public void Win()
        {
            this.strategy.Study(true);
            wincount++;
            gamecount++;
        }

        public void Lose()
        {
            this.strategy.Study(false);
            ++losecount;
            ++gamecount;
        }
        /// <summary>
        /// 平局
        /// </summary>
        public void Even()
        {
            this.gamecount++;
        }

        public override string ToString()
        {
            return "[" + name + ":" + gamecount + " games, " + wincount + " wins, " + losecount + " lose ]";
        }
    }
}