using System;

namespace Problem2234
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine().Split(' ');

            var totalNumberOfHotDogs = int.Parse(line[0]);
            var totalNumberOfParticipants = int.Parse(line[1]);
            var averageHotDogs = (double)totalNumberOfHotDogs / totalNumberOfParticipants;
            
            Console.WriteLine($"{averageHotDogs:0.00}");
        }
    }
}
