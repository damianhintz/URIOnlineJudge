using System;

namespace Problem2059.Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();
            var inputValues = inputLine.Split(' ');
            var p = int.Parse(inputValues[0]); // p: 0 or 1 (if p = 1 then player 1 chooses even, if p = 0 then player 1 chooses odd)
            var p1Number = int.Parse(inputValues[1]); // j1: <1,100> j1, j2, represents respectively the numbers that player 1 chose and the number that player 2 chose. 
            var p2Number = int.Parse(inputValues[2]); // j2: <1,100> j1, j2, represents respectively the numbers that player 1 chose and the number that player 2 chose. 
            var r = int.Parse(inputValues[3]); // r: 0 or 1 (if r = 1 then player 1 cheated, if r = 0 then he/she did not)
            var a = int.Parse(inputValues[4]); // a: 0 or 1 (if a = 1 then he/she did, if a = 0 then he/she did not)

            var p1ChoosesEven = p == 1;
            var p1Cheated = r == 1;
            var p2AccusesOfCheating = a == 1;

            var result1 = OddEvenCheatingResult(p1Cheated, p2AccusesOfCheating);
            if (result1 == true)
            {
                Console.WriteLine("Jogador 1 ganha!");
            }
            else if (result1 == false)
            {
                Console.WriteLine("Jogador 2 ganha!");
            }
            else
            {
                var result2 = OddEvenResult(p1ChoosesEven, p1Number, p2Number);
                if (result2)
                {
                    Console.WriteLine("Jogador 1 ganha!");
                }
                else
                {
                    Console.WriteLine("Jogador 2 ganha!");
                }
            }
        }

        public static bool? OddEvenCheatingResult(bool p1Cheated, bool p2AccusesOfCheating)
        {
            if (p1Cheated)
            {
                if (p2AccusesOfCheating)
                {
                    return false; //P2 wins
                }
                else
                {
                    return true; //P1 wins
                }
            }
            else
            {
                if (p2AccusesOfCheating)
                {
                    return true; //P1 wins
                }
                else
                {
                    return null; //Continue game
                }
            }
        }

        public static bool OddEvenResult(bool p1ChoiceIsEven, int p1Number, int p2Number)
        {
            var sumOfNumbers = p1Number + p2Number;
            var sumOfNumbersIsEven = sumOfNumbers % 2 == 0;
            if (p1ChoiceIsEven)
            {
                if (sumOfNumbersIsEven)
                {
                    return true; //P1 wins
                }
                else
                {
                    return false; //P2 wins
                }
            }
            else
            {
                //P1 choice is odd
                if (sumOfNumbersIsEven)
                {
                    return false; //P2 wins
                }
                else
                {
                    return true; //P1 wins
                }
            }
        }
    }
}