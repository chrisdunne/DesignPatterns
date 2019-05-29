using DesignPatterns.Behavioural.Observer;
using NUnit.Framework;

namespace DesignPatterns.Tests.Behavioural
{
    [TestFixture]
    public class Observer
    {
        [Test]
        public void WhenChannelUpdated_NotifySubscriber()
        {
            IChannel channel = new Channel();
            ISubscriber subscriber = new Subscriber(channel);

            channel.Add(subscriber);
            channel.Notify();

            Assert.Greater(channel.Subscribers.Count, 0);
            Assert.AreEqual(subscriber.Notifications, 1);
        }
    }
}