using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_02
{
    public class Circle : Shape
    {
        private int radius;

        public Circle(int x, int y, int radius) : base(x, y)
        {
            this.radius = radius;
        }

        public override void Show()
        {
            Console.WriteLine($"Circle: Center ({x}, {y}), Radius: {radius}");
        }

        public override string ToString()
        {
            return $"Circle: Center ({x}, {y}), Radius: {radius}";
        }
    }
}
