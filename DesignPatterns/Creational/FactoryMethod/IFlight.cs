namespace DesignPatterns.Creational.FactoryMethod
{
    public interface IFlight
    {
        int SeatsRemaining { get; }

        void CheckAvailability();
    }
}