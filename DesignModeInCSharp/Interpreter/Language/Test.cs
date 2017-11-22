using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace DesignModeInCSharp.Interpreter.Language
{
    public class Test
    {
        public static void Main(string[] args)
        {
            string filename = "..\\..\\commands.txt";
            FileStream filestream = new FileStream(filename, FileMode.Open);
            StreamReader streamReader = new StreamReader(filestream);
            while(!streamReader.EndOfStream)
            {
                string cmds = streamReader.ReadLine();
                Console.WriteLine("text=\"" + cmds + "\"");
                Node node = new ProgramNode();
                node.Parse(new Context(cmds));
                Console.WriteLine("node=" + node);
            }
        }

    }
}
