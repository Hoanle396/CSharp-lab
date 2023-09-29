using System;

namespace Event
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Publisher p = new Publisher();
            SubscriberA sa = new SubscriberA();
            SubscriberB sb = new SubscriberB();

            sa.Sub(p);
            sb.Sub(p);

            p.Send();
        }
    }
}
