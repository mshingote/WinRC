using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinRC
{
    class Program
    {
        static void Main(string[] args)
        {
            int argsLength = args.Length;
            if(argsLength < 2)
            {
                return;
            }
            new CommandParser(args.Skip(0).ToArray()).GetCommandType().Run();
        }
    }
}
