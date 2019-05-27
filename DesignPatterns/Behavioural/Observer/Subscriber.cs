using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.Observer
{
    public class Subscriber : ISubscriber
    {
        private IChannel _channel;

        public Subscriber(IChannel channel)
        {
            _channel = channel;
        }

        public int Notifications { get; private set; }

        public void Update()
        {
            Notifications++;

            _channel.GetLatest();
        }
    }
}