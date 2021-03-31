using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp4breakAndContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IEnumerable<int> numbers = Enumerable.Range(1, 10);

            var breakedNumber = 0;
            foreach(var number in numbers)
            {
                Console.WriteLine($"antes break: {number}");
                if (number == 5)
                {
                    
                    break;
                    
                }
                Console.WriteLine($"despues break: {number}");
                breakedNumber = number;
            }

            Console.WriteLine($"con break en 5 number is: {breakedNumber}");
            Console.WriteLine();
            var continueNumber = 0;
            foreach (var number in numbers)
            {
                Console.WriteLine($"antes continue: {number}");

                if (number == 5)
                {                    
                    continue;
                }
                Console.WriteLine($"despues continue: {number}");
                continueNumber = number;
            }

            Console.WriteLine($"con continue en 5 number is: {continueNumber}");

        }
    }
}
