namespace DesignPatterns.Behavioural.Command
{
    public class Invoker
    {
        private ICommand _turnOn;
        private ICommand _turnOff;

        public Invoker(ICommand turnOn, ICommand turnOff)
        {
            _turnOn = turnOn;
            _turnOff = turnOff;
        }

        public void PressedOn()
        {
            _turnOn.Execute();
        }

        public void PressedOff()
        {
            _turnOff.Execute();
        }
    }
}