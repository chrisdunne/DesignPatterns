using System.Collections.Generic;

namespace DesignPatterns.Behavioural.Observer
{
    public class Channel : IChannel
    {
        public Channel()
        {
            Subscribers = new List<ISubscriber>();
        }

        public List<ISubscriber> Subscribers { get; private set; }

        public void Add(ISubscriber subscriber)
        {
            Subscribers.Add(subscriber);
        }

        public void Notify()
        {
            foreach (ISubscriber subscriber in Subscribers)
            {
                subscriber.Update();
            }
        }

        public void Remove(ISubscriber subscriber)
        {
            Subscribers.Remove(subscriber);
        }

        public string GetLatest()
        {
            return "Cool New Video";
        }
    }
}