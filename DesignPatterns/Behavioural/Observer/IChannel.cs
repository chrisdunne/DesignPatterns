using System.Collections.Generic;

namespace DesignPatterns.Behavioural.Observer
{
    public interface IChannel
    {
        List<ISubscriber> Subscribers { get; }

        void Add(ISubscriber subscriber);

        void Remove(ISubscriber subscriber);

        void Notify();

        string GetLatest();
    }
}