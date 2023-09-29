using System;

namespace EventHandle
{
    public class MyEvent:EventArgs
    {
        public string Data{ get; }
        public MyEvent(string data)
        {
            Data = data;
        }

    }

    // Xây dựng lớp, phát đi sự kiện (data)
    public class ClassA
    {
        public event EventHandler<MyEvent> event_news;

        public void Send()
        {
            event_news?.Invoke(this, new MyEvent("Ban co thong bao moi..."));
        }
    }

    public class ClassB
    {
        public void Sub(ClassA p)
        {
            p.event_news += ReceiverFromPublisher;
        }

        private void ReceiverFromPublisher(object sender, MyEvent e)
        {
            Console.WriteLine("ClassB: " + e.Data);
        }
    }


    public class ClassC
    {
        public void Sub(ClassA p)
        {
            p.event_news += ReceiverFromPublisher;
        }

        private void ReceiverFromPublisher(object sender, MyEvent e)
        {
            Console.WriteLine("ClassC: " + e.Data);
        }
    }

}
