using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModeInCSharp.AbstractFactory
{
    using ListFactory;
    using Factory;
    class Test
    {
        public static void Main(string[] args)
        {
            if(args.Length != 1)
            {
                Console.WriteLine(typeof(ListFactory.ListFactory).ToString());
            }
            else
            {
                Factory.Factory factory = Factory.Factory.GetFactory(args[0]);
                Factory.Link people = factory.CreateLink("China Daily", "http://www.people.com.cn/");
                Factory.Link google = factory.CreateLink("谷歌香港", "http://www.google.com.hk");
                Factory.Link bing = factory.CreateLink("必应搜索", "http://cn.bing.com/");
                Factory.Tray news = factory.CreateTray("日报");
                Factory.Tray searcher = factory.CreateTray("搜索引擎");
                news.Add(people);
                searcher.Add(google);
                searcher.Add(bing);
                Factory.Page page = factory.CreatePage("黄页", "C#");
                page.Add(news);
                page.Add(searcher);
                page.Output();
                Console.ReadKey();
            }
        }
    }
}
