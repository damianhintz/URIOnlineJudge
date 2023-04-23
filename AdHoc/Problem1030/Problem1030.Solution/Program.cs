using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem1030.Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalTestCases = ReadInt();

            for (var caseNumber = 1; caseNumber <= totalTestCases; caseNumber++)
            {
                var inputLineValues = ReadLine().Split(' ');
                var numberOfPeopleInCircle = int.Parse(inputLineValues[0]);
                var sizeOfStep = int.Parse(inputLineValues[1]);
                var lastManStanding = SolveProblemWithLinkedList(numberOfPeopleInCircle, sizeOfStep);
                WriteAnswear(caseNumber, lastManStanding);
            }
        }

        static int SolveProblemWithArray(int numberOfPeopleInCircle, int sizeOfStep)
        {
            var peopleInCircle = new bool[numberOfPeopleInCircle];
            var alivePeople = numberOfPeopleInCircle;
            var currentMan = 0;
            while (alivePeople > 1)
            {
                var skippedPeople = sizeOfStep;
                while (true) //Loop until we will skip sizeOfStep alive people
                {
                    if (peopleInCircle[currentMan] == false) //is alive
                    {
                        if (--skippedPeople == 0)
                        {
                            break;
                        }
                    }

                    //Go to next man
                    currentMan = (currentMan + 1) % numberOfPeopleInCircle;
                }

                peopleInCircle[currentMan] = true; //kill the poor bastard
                alivePeople--;
            }

            //Find the last man standing
            for (var i = 0; i < peopleInCircle.Length; i++)
            {
                if (peopleInCircle[i] == false)
                {
                    return i + 1; //The last man standing
                }
            }

            return 1; //Not possible
        }

        static int SolveProblemWithLinkedList(int count, int step)
        {
            var alivePeople = new LinkedList<int>(Enumerable.Range(1, count));
            var currentMan = alivePeople.First;
            while (alivePeople.Count > 1)
            {
                for (var i = 1; i < step; i++)
                {
                    currentMan = currentMan.Next;
                    if (currentMan == null)
                    {
                        currentMan = alivePeople.First;
                    }
                }

                //Kill that man
                var killThisMan = currentMan;
                currentMan = currentMan.Next;
                if (currentMan == null){
                    currentMan = alivePeople.First;
                }

                alivePeople.Remove(killThisMan);
            }

            return alivePeople.First.Value;
        }

        static void WriteAnswear(int caseNumber, int lastManStanding)
        {
            Console.WriteLine($"Case {caseNumber}: {lastManStanding}");
        }

        static int ReadInt()
        {
            return int.Parse(ReadLine());
        }

        static string ReadLine()
        {
            return Console.ReadLine();
        }
    }

}