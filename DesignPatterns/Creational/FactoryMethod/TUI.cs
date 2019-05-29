using System;

namespace DesignPatterns.Creational.FactoryMethod
{
    public class TUI : Airline
    {
        public override IFlight GetFlight(DateTime date)
        {
            return new TUIFlight();
        }
    }
}