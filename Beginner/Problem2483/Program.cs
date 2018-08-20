using System;

namespace Problem2483
{
    class Program
    {
        static void Main(string[] args)
        {
            var happinessIndex = int.Parse(Console.ReadLine());
            var answer = new ProblemSolver2483()
                .GetMerryChristmasInPortuguese(happinessIndex);
            Console.WriteLine(answer);
        }
    }

    public class ProblemSolver2483
    {
        public string GetMerryChristmasInPortuguese(int happinessIndex)
        {
            var repeatedA = new string('a', happinessIndex);
            return $"Feliz nat{repeatedA}l!";
        }
    }
}
