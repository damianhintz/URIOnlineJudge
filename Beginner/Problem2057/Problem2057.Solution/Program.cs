using System;

namespace Problem2057.Solution
{
    public class URI
    {
        static void Main(string[] args)
        {
            //Input
            var split = Console.ReadLine().Split(' ');
            var timeOfDepature = int.Parse(split[0]);
            var travelTime = int.Parse(split[1]);
            var timeZone = int.Parse(split[2]);

            //Output
            //Print an integer that indicates the local time specified in destination.
            var localTime = GetLocalTimeArray(timeOfDepature, travelTime, timeZone);
            Console.WriteLine(localTime);
        }

        public static int GetLocalTime(int timeOfDepature, int travelTime, int timeZone)
        {
            var localTime = timeOfDepature + travelTime + timeZone;
            if (localTime < 0)
            {
                return 24 + localTime;
            }
            else if (localTime >= 24)
            {
                return localTime - 24;
            }
            else
            {
                return localTime;
            }
        }

        static int[] _localTime = {
    20, //20 -4 = 0 + 1 - 5
    21, //21 -3 = 0 + 1 - 4
    22, //22 -2
    23,//23 -1
    0, //0
    1, //1
    2,
    3,
    4,
    5,
    6,
    7,
    8,
    9,
    10,
    11,
    12,
    13,
    14,
    15,
    16,
    17, //17
    18,
    19,
    20,
    21,
    22,
    23, //23
    0, //24
    1,
    2,
    3,
    4,
    5,
    6, //30
    7,
    8,
    9,
    10,//34
    11,//35
    12,
    13,
    14,
    15,
    16 //40
};
        public static int GetLocalTimeArray(int timeOfDepature, int travelTime, int timeZone)
        {
            var localTime = timeOfDepature + travelTime + timeZone;
            var localTimeIndex = localTime + 4;
            return _localTime[localTimeIndex];
        }
    }
}