using System;

namespace FactoryDesign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDuck goose = DuckFactory.GetDuck("Medium");
            goose.Action();
        }
    }
}
