using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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