using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallbackFunction
{
    internal class CallBack
    {
        static void TinhTong(int a, int b, Action<int> callback)
        {
            int c = a + b;
            callback(c);
        }

        public static void TestTinhTong()
        {
            TinhTong(5, 6, (x) => Console.WriteLine($"Tong hai so la: {x}"));
        }
    }
}
