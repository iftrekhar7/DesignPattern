namespace CommandPattern.Command
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
