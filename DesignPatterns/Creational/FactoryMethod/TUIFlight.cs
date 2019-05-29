namespace DesignPatterns.Creational.FactoryMethod
{
    internal class TUIFlight : IFlight
    {
        public int SeatsRemaining { get; private set; }

        public void CheckAvailability()
        {
        }
    }
}