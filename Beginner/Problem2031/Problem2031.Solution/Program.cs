using System;

namespace Problem2031.Solution
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int testCasesNumber = ReadInteger();
            for (var i = 0; i < testCasesNumber; i++)
            {
                var player1Sign = ReadPlayerSign();
                var player2Sign = ReadPlayerSign();
                Console.WriteLine(GetWinner(player1Sign, player2Sign));
            }
        }

        static string GetWinner(PlayerSign p1, PlayerSign p2)
        {
            if (p1 == PlayerSign.Airstrike && p2 == PlayerSign.Airstrike)
            {
                return "Aniquilacao mutua"; //Aniquilacao mutua: if Mutual Annihilation occurs
            }

            if (p1 == PlayerSign.Rock && p2 == PlayerSign.Rock)
            {
                return "Sem ganhador"; //Sem ganhador: if there is no winner
            }

            if (p1 == PlayerSign.Paper && p2 == PlayerSign.Paper)
            {
                return "Ambos venceram"; //Ambos venceram: if the both have won the game
            }

            if (p1 > p2)
            {
                return "Jogador 1 venceu"; //Jogador 1 venceu: if Player 1 has won the game
            }

            return "Jogador 2 venceu"; //“Jogador 2 venceu”: if Player 2 has won the game
        }

        static int ReadInteger()
        {
            var inputLine = ReadLine();
            return int.Parse(inputLine);
        }

        static PlayerSign ReadPlayerSign()
        {
            var inputLine = ReadLine();
            switch (inputLine.ToLower())
            {
                case "papel": return PlayerSign.Paper;
                case "pedra": return PlayerSign.Rock;
                default: return PlayerSign.Airstrike; //ataque
            }
        }

        static string ReadLine()
        {
            return Console.ReadLine();
        }
    }

    public enum PlayerSign
    {
        Paper = 0,
        Rock = 1,
        Airstrike = 2
    }
}
