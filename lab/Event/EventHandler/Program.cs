using System;

namespace EventHandle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassA p = new ClassA();
            ClassB sa = new ClassB();
            ClassC sb = new ClassC();

            sa.Sub(p); 
            sb.Sub(p); 

            p.Send();
        }
    }
}
