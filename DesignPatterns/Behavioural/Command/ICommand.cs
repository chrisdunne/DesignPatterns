namespace DesignPatterns.Behavioural.Command
{
    public interface ICommand
    {
        void Execute();

        void Undo();
    }
}