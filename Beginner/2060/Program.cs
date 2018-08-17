using System;
using System.Linq;

namespace Problem2060
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine().Trim();
            var amountOfNumbers = int.Parse(line);
            var numbersLine = Console.ReadLine().Trim();
            var numbersSplit = numbersLine.Split(' ').Take(amountOfNumbers);
            var numbers = from n in numbersSplit select int.Parse(n);
            var multiplesOf2 = numbers.Where(n => n % 2 == 0);
            Console.WriteLine("{0} Multiplo(s) de 2", multiplesOf2.Count());
            var multiplesOf3 = numbers.Where(n => n % 3 == 0);
            Console.WriteLine("{0} Multiplo(s) de 3", multiplesOf3.Count());
            var multiplesOf4 = numbers.Where(n => n % 4 == 0);
            Console.WriteLine("{0} Multiplo(s) de 4", multiplesOf4.Count());
            var multiplesOf5 = numbers.Where(n => n % 5 == 0);
            Console.WriteLine("{0} Multiplo(s) de 5", multiplesOf5.Count());
        }
    }
}
