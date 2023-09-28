using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX4
{
    internal class Tesla : ICars, IElectricCar
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public int Battery { get; set; }
        public Tesla(string model, string color, int battery)
        {
            Model = model;
            Color = color;
            Battery = battery;
        }

        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }
        public new string ToString(){
             return $"{Color} Tesla {Model} with {Battery} Batteries \n{Start()}\n{Stop()}";
        }
    }
}
