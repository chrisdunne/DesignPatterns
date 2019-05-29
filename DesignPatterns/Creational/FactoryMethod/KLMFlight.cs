namespace DesignPatterns.Creational.FactoryMethod
{
    internal class KLMFlight : IFlight
    {
        public int SeatsRemaining { get; private set; }

        public void CheckAvailability()
        {
        }
    }
}