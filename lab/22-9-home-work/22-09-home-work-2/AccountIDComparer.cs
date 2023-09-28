using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_09_home_work_2
{
    class AccountIDComparer : IComparer
    {
        public int Compare(object? x, object? y)
        {
            Account? left = x as Account;
            Account? right = y as Account;
            if (left is null || right is null) throw new ArgumentException();
            return String.Compare(left.ID, right.ID);
        }
    }
}
