using CommandPattern.Command;
using CommandPattern.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.ConcreteCommand
{
    public class LightOnCommand : ICommand
    {
        Light light;

        public LightOnCommand(Light light)
        {
            this.light = light;
        }

        public void Execute() => light.On();

        public void Undo() => light.Off();
    }
}
