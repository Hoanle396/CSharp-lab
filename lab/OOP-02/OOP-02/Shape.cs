using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_02
{
    public abstract class Shape
    {
        protected int x;
        protected int y;

        public Shape(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Move(int dx, int dy)
        {
            x += dx;
            y += dy;
        }

        public abstract void Show();
    }

}
