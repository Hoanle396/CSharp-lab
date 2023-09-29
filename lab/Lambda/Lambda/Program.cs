using System;

namespace Lambda
{
    internal class Program
    {
        public delegate int TinhToan(int a, int b);
        static void Main(string[] args)
        {

            // Gán biểu thức lambda cho delegate
            TinhToan tinhtong = (int x, int y) => {
                return x + y;
            };

            tinhtong += (int x, int y) => x + y;

            int kq = tinhtong(5, 1); 
            Console.WriteLine(kq);
        }
    }
}
