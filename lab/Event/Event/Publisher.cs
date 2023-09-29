using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    internal class Publisher
    {
        public delegate void NotifyNews(object data);

        public NotifyNews event_news;

        public void Send()
        {
            event_news?.Invoke("Ban co thong bao moi");
        }
    }
}
