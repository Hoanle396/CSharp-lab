using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_01_04
{
    internal class Fraction
    {
        private int n1;
        private int n2;
        private int d1;
        private int d2;

        private int numerator;
        private int denominator;

        public void InputFractions()
        {
            Console.WriteLine("Enter the first fraction:");
            n1 = ReadInt("Numerator: ");
            d1 = ReadInt("Denominator: ");
            Console.WriteLine();

            Console.WriteLine("Enter the second fraction:");
            n2 = ReadInt("Numerator: ");
            d2 = ReadInt("Denominator: ");

        }

        public void AddFractions()
        {
            numerator = n1 * d2 + n2 * d1;
            denominator = d1*d2;

        }

        public void SubtractFractions()
        {
            numerator = n1 * d2 - n2 * d1;
            denominator =d1*d2;

        }

        public void MultiplyFractions()
        {
            numerator = n1*n2;
            denominator = d1*d2;

        }

        public void DivideFractions()
        {
            numerator = n1*d2;
            denominator = d1 * n2;

        }

        public void DisplayFraction()
        {
            Console.WriteLine($"Fraction: ({numerator}/{denominator})");
        }

        public void DisplayDecimal()
        {
            float result = (float)numerator / denominator;
            Console.WriteLine($"Decimal: {result}");
        }

        private int ReadInt(string message)
        {
            int value;
            while (true)
            {
                Console.Write(message);
                if (int.TryParse(Console.ReadLine(), out value))
                    return value;
                Console.WriteLine("Invalid input. Please enter an integer.");
            }
        }
    }
}
