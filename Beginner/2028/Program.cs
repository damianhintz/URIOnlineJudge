using System;

namespace Problem2028
{
    class Program
    {
        static int[][] _numbers = new int[201][];
        static string[] _strings = new string[201];

        static void Main(string[] args)
        {
            Precompute();
            string line;
            int caseNumber = 1;
            while ((line = Console.ReadLine()) != null)
            {
                SolveProblem(caseNumber++, int.Parse(line.Trim()));
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="caseNumber"></param>
        /// <param name="numberOfNumbers">0-200</param>
        static void SolveProblem(int caseNumber, int numberOfNumbers)
        {
            int numbers = _numbers[numberOfNumbers].Length;
            if (numbers < 2) Console.WriteLine("Caso {0}: {1} numero", caseNumber, numbers);
            else Console.WriteLine("Caso {0}: {1} numeros", caseNumber, numbers);
            Console.WriteLine(_strings[numberOfNumbers]);
            Console.WriteLine();
        }

        /// <summary>
        /// Optymalizacja poprzez wstępne obliczenie każdego przypadku.
        /// </summary>
        static void Precompute()
        {
            for (int i = 0; i < _numbers.Length; i++)
            {
                int n = (i * (i + 1)) / 2 + 1;
                _numbers[i] = new int[n];
                _numbers[i][0] = 0;
                int l = 1;
                for (int k = 1; k <= i; k++)
                {
                    for (int j = 0; j < k; j++, l++)
                    {
                        _numbers[i][l] = k;
                    }
                }
                _strings[i] = string.Join(" ", _numbers[i]);
            }
        }
    }
}
