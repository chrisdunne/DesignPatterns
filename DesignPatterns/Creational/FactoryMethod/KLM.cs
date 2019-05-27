using System;

namespace DesignPatterns.Creational.FactoryMethod
{
    public class KLM : Airline
    {
        public override IFlight GetFlight(DateTime date)
        {
            return new KLMFlight();
        }
    }
}
