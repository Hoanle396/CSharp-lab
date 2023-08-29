using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_02
{
    public class PolyLine : Shape
    {
        public PolyLine(int x, int y) : base(x, y)
        {
        }

        public override void Show()
        {
            Console.WriteLine($"PolyLine: ({x}, {y})");
        }

        public override string ToString()
        {
            return $"PolyLine: ({x}, {y})";
        }
    }
}
