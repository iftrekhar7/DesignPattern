using CommandPattern.Command;
using CommandPattern.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.ConcreteCommand
{
    public class CeilingFanOffCommand : ICommand
    {
        private CeilingFan ceilingFan;
        int prevSpeed;

        public CeilingFanOffCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            prevSpeed = ceilingFan.GetSpeed();
            ceilingFan.Off();
        } 

        public void Undo() => ceilingFan.GoToPreviousState(prevSpeed);


    }
}
