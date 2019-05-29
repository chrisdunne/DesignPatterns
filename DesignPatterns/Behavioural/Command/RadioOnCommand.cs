namespace DesignPatterns.Behavioural.Command
{
    public class RadioOnCommand : ICommand
    {
        private RadioReceiver _receiver;

        public RadioOnCommand(RadioReceiver receiver)
        {
            _receiver = receiver;
        }

        public void Execute()
        {
            _receiver.On();
        }

        public void Undo()
        {
            _receiver.Off();
        }
    }
}