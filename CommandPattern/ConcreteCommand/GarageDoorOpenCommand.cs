using CommandPattern.Command;
using CommandPattern.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.ConcreteCommand
{
    public class GarageDoorOpenCommand : ICommand
    {
        GarageDoor garageDoor;

        public GarageDoorOpenCommand(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }

        public void Execute() => garageDoor.Up();

        public void Undo() => garageDoor.Down();
    }
}
