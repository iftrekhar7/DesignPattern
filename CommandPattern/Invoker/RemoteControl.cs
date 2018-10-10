using CommandPattern.Command;
using CommandPattern.ConcreteCommand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Invoker
{
    public class RemoteControl
    {
        ICommand[] onCommands;
        ICommand[] offCommands;
        ICommand undoCommand;
        ICommand noCommand = new NoCommand();

        public RemoteControl()
        {
            onCommands = new ICommand[7];
            offCommands = new ICommand[7];

            for (int i = 0; i < 7; i++)
            {
                onCommands[i] = noCommand;
                offCommands[i] = noCommand;
            }
            undoCommand = noCommand;
        }

        public void SetCommand( int slot, ICommand onCommand, ICommand offCommand)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }

        public void OnButtonWasPushed(int slot)
        {
            onCommands[slot].Execute();
            undoCommand = onCommands[slot];
        }

        public void OffButtonWasPushed(int slot)
        {
            offCommands[slot].Execute();
            undoCommand = offCommands[slot];
        }

        public void undoButtonWasPushed()
        {
            undoCommand.Undo();
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append("\n----------Remote Control ------------\n");
            for (int i = 0; i < onCommands.Length; i++)
            {
                stringBuilder.Append("[Slot " + i + "] " + onCommands[i].GetType().ToString()
                    + "    " + offCommands[i].GetType().ToString() + "\n");
            }

            return stringBuilder.ToString();
        }
    }
}
