using CommandPattern.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Invoker
{
    public class SimpleRemoteControl
    {
        ICommand slot;

        public SimpleRemoteControl() { }

        public void SetCommand(ICommand command)
        {
            slot = command;
            //this could be called multiple times if the client or this code wanted to change the behavior of the remote button
        }

        public void buttonWasPressed()
        {
            //all we do take the current command bound to the slot and call its execute() method
            slot.Execute();
        }
    }
}
