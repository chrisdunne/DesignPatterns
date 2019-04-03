using System;

namespace DesignPatterns.Creational.SimpleFactory
{
    public class DrinkSimpleFactory
    {
        public static IDrink GetDrink(DrinkType type)
        {
            switch (type)
            {
                case DrinkType.Beer:
                    return new Beer();
                case DrinkType.Coffee:
                    return new Coffee();
                default:
                    throw new InvalidOperationException("The requested drink is not available.");
            }
        }
    }
}
