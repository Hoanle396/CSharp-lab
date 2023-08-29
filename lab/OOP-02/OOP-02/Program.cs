using System;

namespace OOP_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Line line = new Line(0, 0, 5, 5);
            line.Show();

            Circle circle = new Circle(3, 3, 5);
            circle.Show();

            Rectangle rect = new Rectangle(0, 0, 4, 0, 4, 2);
            rect.Show();

            PolyLine polyline = new PolyLine(1, 1);
            polyline.Show();
        }
    }
}
