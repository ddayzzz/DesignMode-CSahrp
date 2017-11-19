using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModeInCSharp.Visitor
{
    public class ListVisitor : Visitor
    {
        private string currentDir;

        public override void Visit(DesignModeInCSharp.Visitor.Directory directory)
        {
            Console.WriteLine(currentDir + "/" + directory.ToString());
            string savedir = currentDir;
            currentDir = currentDir + "/" + directory.Name;
            var iter = directory.Iterator();
            while(iter.MoveNext())
            {
                Entry entry = iter.Current;
                entry.Accept(this);
            }
            currentDir = savedir;
        }

        public override void Visit(DesignModeInCSharp.Visitor.File file)
        {
            Console.WriteLine(currentDir + "/" + file.ToString());
        }
    }
}
