using System;
using System.Collections.Generic;
using System.Globalization;

namespace Problem2029.Solution
{
    class Program
    {
        const double PI = 3.14;

        static void Main(string[] args)
        {
            var consoleReader = new ConsoleReader();

            string volumeToken;
            while ((volumeToken = consoleReader.NextToken()) != null)
            {
                var volume = double.Parse(volumeToken, CultureInfo.InvariantCulture);
                var diameterToken = consoleReader.NextToken();
                var diameter = double.Parse(diameterToken, CultureInfo.InvariantCulture);
                var r = diameter / 2;
                var area = PI * r * r;
                var h = volume / area;
                Console.WriteLine($"ALTURA = {h:F2}");
                Console.WriteLine($"AREA = {area:F2}");
            }
        }
    }

    class ConsoleReader
    {
        private Queue<string> _tokens = new Queue<string>();

        public string NextToken()
        {
            if (_tokens.Count > 0)
            {
                return _tokens.Dequeue();
            }

            var inputLine = Console.ReadLine();
            if (inputLine == null)
            {
                return null;
            }

            var inputTokens = inputLine.Split(' ');
            foreach (var inputToken in inputTokens)
            {
                _tokens.Enqueue(inputToken);
            }

            return _tokens.Dequeue();
        }
    }
}
