using CommandPattern.Command;
using CommandPattern.Receiver;

namespace CommandPattern.ConcreteCommand
{
    public class CeilingFanOnCommand : ICommand
    {
        private CeilingFan ceilingFan;
        int prevSpeed;

        public CeilingFanOnCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            prevSpeed = ceilingFan.GetSpeed();
            ceilingFan.On();
        }

        public void Undo() => ceilingFan.GoToPreviousState(prevSpeed);
    }
}
