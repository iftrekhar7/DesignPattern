using CommandPattern.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.ConcreteCommand
{
    public class MacroCommand : ICommand
    {
        ICommand[] commands;

        public MacroCommand(ICommand[] commands)
        {
            this.commands = commands;
        }

        public void Execute()
        {
            for (int i = 0; i < commands.Length; i++)
            {
                commands[i].Execute();
            }
        }

        public void Undo()
        {
            for (int i = 0; i < commands.Length; i++)
            {
                commands[i].Undo();
            }
        }
    }
}
