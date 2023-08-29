using System;

namespace OOP_01_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction fraction = new Fraction();

            fraction.InputFractions();
            Console.WriteLine("Add Fractions");
            fraction.AddFractions();
            fraction.DisplayFraction();
            fraction.DisplayDecimal();

            Console.WriteLine("Subtract Fractions");
            fraction.SubtractFractions();
            fraction.DisplayFraction();
            fraction.DisplayDecimal();

            Console.WriteLine("Divide Fractions");
            fraction.DivideFractions();
            fraction.DisplayFraction();
            fraction.DisplayDecimal();

            Console.WriteLine("Multiply Fractions");
            fraction.MultiplyFractions();
            fraction.DisplayFraction();
            fraction.DisplayDecimal();
        }
    }
}
