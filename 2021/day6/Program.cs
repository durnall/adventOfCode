using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace day6
{
    class Program
    {
        static void Main(string[] args)
        {
            var puzzleInput = @"3,4,3,1,2".Split(",").Select( n=>int.Parse(n)); // test input
            puzzleInput = @"1,1,1,1,1,5,1,1,1,5,1,1,3,1,5,1,4,1,5,1,2,5,1,1,1,1,3,1,4,5,1,1,2,1,1,1,2,4,3,2,1,1,2,1,5,4,4,1,4,1,1,1,4,1,3,1,1,1,2,1,1,1,1,1,1,1,5,4,4,2,4,5,2,1,5,3,1,3,3,1,1,5,4,1,1,3,5,1,1,1,4,4,2,4,1,1,4,1,1,2,1,1,1,2,1,5,2,5,1,1,1,4,1,2,1,1,1,2,2,1,3,1,4,4,1,1,3,1,4,1,1,1,2,5,5,1,4,1,4,4,1,4,1,2,4,1,1,4,1,3,4,4,1,1,5,3,1,1,5,1,3,4,2,1,3,1,3,1,1,1,1,1,1,1,1,1,4,5,1,1,1,1,3,1,1,5,1,1,4,1,1,3,1,1,5,2,1,4,4,1,4,1,2,1,1,1,1,2,1,4,1,1,2,5,1,4,4,1,1,1,4,1,1,1,5,3,1,4,1,4,1,1,3,5,3,5,5,5,1,5,1,1,1,1,1,1,1,1,2,3,3,3,3,4,2,1,1,4,5,3,1,1,5,5,1,1,2,1,4,1,3,5,1,1,1,5,2,2,1,4,2,1,1,4,1,3,1,1,1,3,1,5,1,5,1,1,4,1,2,1".Split(",").Select( n=>int.Parse(n));
            
            Int64[] fishCount = new Int64[9];
            foreach (var n in puzzleInput)
            {
                fishCount[n]++;
            }

            var noOfDays = 256;

            for (int i = 0; i < noOfDays; i++)
            {
                var spawns = fishCount[0]; //this is how many 8s and 6s need adding
                fishCount[0] = fishCount[1];
                fishCount[1] = fishCount[2];
                fishCount[2] = fishCount[3];
                fishCount[3] = fishCount[4];
                fishCount[4] = fishCount[5];
                fishCount[5] = fishCount[6];
                fishCount[6] = fishCount[7] + spawns;
                fishCount[7] = fishCount[8];
                fishCount[8] = spawns;

                Console.WriteLine($"{i}");
            }
            Console.WriteLine($"{fishCount.Sum( n=>n)}");
        }
    }
}
