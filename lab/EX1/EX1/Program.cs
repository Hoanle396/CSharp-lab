using System;
using System.Collections.Generic;

namespace EX1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 2, 3, 4, 4, 4 };
            List<int> result = SumAdjacentEqualNumbers(numbers);

            Console.WriteLine("Original List: " + string.Join(", ", numbers));
            Console.WriteLine("Result: " + string.Join(", ", result));
        }
        static List<int> SumAdjacentEqualNumbers(List<int> numbers)
        {
            List<int> result = new List<int>();
            int i = 0;
            int n = numbers.Count;

            while (i < n)
            {
                int currentNumber = numbers[i];
                int sum = currentNumber;

                // Check if the next number is equal to the current number
                while (i + 1 < n && numbers[i + 1] == currentNumber)
                {
                    sum += numbers[i + 1];
                    i++;
                }

                result.Add(sum);
                i++;
            }

            return result;
        }
    }
}
