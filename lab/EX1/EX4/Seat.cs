using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX4
{
    internal class Seat : ICars
    {
        public string Model { get; set; }
        public string Color { get; set ; }
        public Seat(string model, string color)
        {
            Model = model;
            Color = color;
        }
        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }
        public new string ToString()
        {
            return $"{Color} Seat {Model} \n{Start()}\n{Stop()}";
        }
    }
}
