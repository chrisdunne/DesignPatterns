namespace DesignPatterns.Behavioural.Command
{
    public class RadioOffCommand : ICommand
    {
        private RadioReceiver _receiver;

        public RadioOffCommand(RadioReceiver receiver)
        {
            _receiver = receiver;
        }

        public void Execute()
        {
            _receiver.Off();
        }

        public void Undo()
        {
            _receiver.On();
        }
    }
}