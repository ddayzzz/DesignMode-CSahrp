using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModeInCSharp.Builder
{
    public class Director
    {
        private Builder builder;
        public  Director(Builder builder)
        {
            this.builder = builder;
        }
        public void Construct()
        {
            builder.MakeTitle("Greeting");
            builder.MakeString("\t从早上到下午");
            builder.MakeItem(new string[]
            {
                "早上好。",
                "下午好。"
            });
            builder.MakeString("\t晚上");
            builder.MakeItem(new string[]
            {
                "晚上好。",
                "晚安。",
                "再见。"
            });
            builder.Close();
        }
    }
}
