using DesignPatterns.Creational.SimpleFactory;
using NUnit.Framework;

namespace DesignPatterns.Tests.Creational
{
    [TestFixture]
    public class SimpleFactory
    {
        [Test]
        public void WhenCreatingACoffee_ThenFactoryShouldReturnCoffee()
        {
            var expected = new Coffee();
            var actual = DrinkSimpleFactory.GetDrink(DrinkType.Coffee);

            Assert.That(actual.GetType(), Is.EqualTo(expected.GetType()));
        }

        [Test]
        public void WhenCreatingABeer_ThenFactoryShouldReturnBeer()
        {
            var expected = new Beer();
            var actual = DrinkSimpleFactory.GetDrink(DrinkType.Beer);

            Assert.That(actual.GetType(), Is.EqualTo(expected.GetType()));
        }
    }
}