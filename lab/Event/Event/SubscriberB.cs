using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    internal class SubscriberB
    {
        public void Sub(Publisher p)
        {
            p.event_news += ReceiverFromPublisher;
        }

        void ReceiverFromPublisher(object data)
        {
            Console.WriteLine("SubscriberB: " + data.ToString());
        }
    }
}
