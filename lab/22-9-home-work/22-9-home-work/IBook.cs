using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_9_home_work
{
    internal interface IBook
    {
        string this[int index] { get; set; }

        string Title { get; set; }
        string Author { get; set; }
        string Publisher { get; set; }
        int Year { get; set; }
        string ISBN { get; set; }
        void Show();

    }
}
