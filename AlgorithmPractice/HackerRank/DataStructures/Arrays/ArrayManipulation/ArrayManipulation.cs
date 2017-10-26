﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.HackerRank.DataStructures.Arrays.ArrayManipulation
{
    public class ArrayManipulation : HackerRankProblem
    {
        public ArrayManipulation(Queue<string> input)
        {
            Console = new MockConsole(input);
        }

        public override List<string> Solve()
        {
            string[] inString = Console.ReadLine().Split(' ');
            uint[] initParams = Array.ConvertAll(inString, UInt32.Parse);
            uint n = initParams[0];
            uint m = initParams[1];

            long[] numList = new long[n + 1];

            for (int i = 0; i < m; i++)
            {
                string[] opString = Console.ReadLine().Split(' ');
                uint a = UInt32.Parse(opString[0]);
                uint b = UInt32.Parse(opString[1]);
                long k = long.Parse(opString[2]);

                numList[a] += k;
                if (b + 1 <= n) numList[b + 1] -= k;
            }

            long tempMax = 0;
            long max = 0;
            for (int i = 1; i <= n; i++)
            {
                tempMax += numList[i];
                if (tempMax > max) max = tempMax;
            }

            Console.WriteLine(max.ToString());

            return Console.Output;
        }
    }
}
