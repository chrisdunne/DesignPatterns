using System;

namespace DesignPatterns.Creational.FactoryMethod
{
    public abstract class Airline
    {
        public IFlight SearchFlight(DateTime date)
        {
            IFlight flight = GetFlight(date);
            flight.CheckAvailability();
            return flight;
        }

        public abstract IFlight GetFlight(DateTime date);
    }
}