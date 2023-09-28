using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_9_home_work
{
    internal class BookYearComparer
    {
        public int Compare(Book? x, Book? y)
        {
            if (x == null || y == null)
            {
                throw new ArgumentNullException();
            }

            return x.Year.CompareTo(y.Year);
        }
    }
}
