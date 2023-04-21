using System;

namespace Problem2126.Solution
{
    public class Program
    {
        static void Main(string[] args)
        {
            string n1;
            var testCaseNumber = 0;
            while ((n1 = ReadLine()) != null)
            {
                testCaseNumber++;
                var n2 = ReadLine();

                var solutionResult = SolveProblem(n1, n2);

                if (solutionResult.NumberOfSubstrings == 0)
                {
                    Console.WriteLine($"Caso #{testCaseNumber}:"); //Caso #2:
                    Console.WriteLine("Nao existe subsequencia");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine($"Caso #{testCaseNumber}:"); //Caso #2:
                    Console.WriteLine($"Qtd.Subsequencias: {solutionResult.NumberOfSubstrings}"); //Qtd.Subsequencias: 3
                    Console.WriteLine($"Pos: {solutionResult.LastSubstringIndex}"); //Pos: 24
                    Console.WriteLine();
                }
            }
        }

        static string ReadLine()
        {
            return Console.ReadLine();
        }

        public static SolutionResult SolveProblem(string n1, string n2)
        {
            var numberOfSubstrings = 0;
            var lastSubstringIndex = 0;
            for (var n2Index = 0; n2Index < n2.Length - n1.Length + 1; n2Index++)
            {
                var isSubstring = true;
                var n3Index = n2Index;
                for (var n1Index = 0; n1Index < n1.Length; n1Index++, n3Index++)
                {
                    if (n1[n1Index] != n2[n3Index])
                    {
                        isSubstring = false;
                        break;
                    }
                }
                if (isSubstring)
                {
                    lastSubstringIndex = n2Index + 1;
                    numberOfSubstrings++;
                }
            }

            return new SolutionResult
            {
                NumberOfSubstrings = numberOfSubstrings,
                LastSubstringIndex = lastSubstringIndex
            };
        }
    }

    public struct SolutionResult
    {
        public int NumberOfSubstrings;
        public int LastSubstringIndex;
    }
}