using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.HackerRank.DataStructures.Arrays.ArrayManipulation
{
    public class ArrayManipulationNotOptimal : HackerRankProblem
    {
        public ArrayManipulationNotOptimal(Queue<string> input)
        {
            Console = new MockConsole(input);
        }

        public override List<string> Solve()
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int m = Convert.ToInt32(tokens_n[1]);
            long max = long.MinValue;
            long[] finalArray = new long[n];
            for (int a0 = 0; a0 < m; a0++)
            {
                string[] tokens_a = Console.ReadLine().Split(' ');
                int a = Convert.ToInt32(tokens_a[0]) - 1; //account for the 1 indexed array
                int b = Convert.ToInt32(tokens_a[1]) - 1; //account for the 1 indexed array
                int k = Convert.ToInt32(tokens_a[2]);

                for (int i = a; i <= b; i++)
                {
                    finalArray[i] += k;
                    max = Math.Max(max, finalArray[i]);
                }
            }

            Console.WriteLine(max);

            return Console.Output;
        }
    }
}
