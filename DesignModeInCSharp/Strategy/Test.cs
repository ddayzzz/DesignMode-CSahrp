using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModeInCSharp.Strategy
{
    public class Test
    {
        public static void Main()
        {
            Player shu = new Player("Shu", new WinningStrategy(98));
            Player qiang = new Player("Qiang", new WinningStrategy(99));
            for(int i=0;i<1000;++i)
            {
                Hand p1 = shu.NextHand();
                Hand p2 = qiang.NextHand();
                if(p1.IsStrongerThan(p2))
                {
                    Console.WriteLine("Winner : " + shu);
                    shu.Win();
                    qiang.Lose();
                }
                else
                {
                    if(p2.IsStrongerThan(p1))
                    {
                        Console.WriteLine("Winner : " + qiang);
                        shu.Lose();
                        qiang.Win();
                    }
                    else
                    {
                        Console.WriteLine("Even");
                        shu.Even();
                        qiang.Even();
                    }
                }
            }
            Console.WriteLine(shu);
            Console.WriteLine(qiang);
        }
    }
}
