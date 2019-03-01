using DesignPatterns.Singleton;
using NUnit.Framework;

namespace DesignPatterns.Tests
{
    [TestFixture]
    public class Singleton
    {
        [Test]
        public void WhenAcquiringTwoLoggerInstances_CheckBothReferToTheSameInstance()
        {
            var loggerA = Logger.GetInstance();

            loggerA.Message = "First Instance";

            var loggerB = Logger.GetInstance();

            Assert.That(loggerA.Message, Is.EqualTo(loggerB.Message));
            Assert.That(loggerB.Message, Is.EqualTo("First Instance"));

            loggerB.Message = "Second Instance";

            Assert.That(loggerA.Message, Is.EqualTo(loggerB.Message));
            Assert.That(loggerA.Message, Is.EqualTo("Second Instance"));
        }
    }
}