using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX4
{
    internal interface ICars
    {
        string Model { get; set; }
        string Color { get; set; }
        string Start();
        string Stop();
        string ToString();
    }
}
