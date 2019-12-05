using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinRC
{
    class CommandParser
    {
        private static Dictionary<string, ICommand> commandType = new Dictionary<string, ICommand>
        {
            {"o", new OpenAppCommand() },
            {"open", new OpenAppCommand() },
        };
        private string command = null;
        private string appName = null;

        public CommandParser(string[] command)
        {
            if(command?.Length == 0)
            {
                throw new CommandException("Command Not Given.");
            }
            this.command = command[0];
            this.appName = command[1];
        }
        public ICommand GetCommandType()
        {
            if (commandType.ContainsKey(this.command))
            {
                commandType[this.command].Args = appName;
                return commandType[this.command];
            }
            throw new CommandException("Command Not Implemented.");
        }
    }
}
