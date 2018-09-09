using System;

namespace Problem2165
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var isTweet = new ProblemSolver2165().IsTweet(text);
            var answer = isTweet ? "TWEET" : "MUTE";
            Console.WriteLine(answer);
        }
    }

    public class ProblemSolver2165
    {
        private const int TWEET_MAX_LENGTH = 140;

        public bool IsTweet(string text)
        {
            return text.Length <= TWEET_MAX_LENGTH;
        }
    }
}
