using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_02
{
    public class Line : Shape
    {
        private int x2;
        private int y2;

        public Line(int x1, int y1, int x2, int y2) : base(x1, y1)
        {
            this.x2 = x2;
            this.y2 = y2;
        }

        public override void Show()
        {
            Console.WriteLine($"Line: ({x}, {y}) to ({x2}, {y2})");
        }

        public override string ToString()
        {
            return $"Line: ({x}, {y}) to ({x2}, {y2})";
        }
    }

}
