using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.HackerRank.DataStructures
{
    public abstract class HackerRankProblem
    {
        public abstract List<string> Solve();
        /// <summary>
        /// This makes it easy to copy/paste the answer out to HackerRank.
        /// </summary>
        protected MockConsole Console { get; set; }
    }
    
    public class MockConsole
    {
        private Queue<string> _input;

        public List<string> Output { get; set; } = new List<string>();

        public MockConsole(Queue<string> input)
        {
            _input = input;
        }

        public string ReadLine()
        {
            return _input.Dequeue();
        }

        public void WriteLine<T>(T val)
        {
            Output.Add(val.ToString());
        }
    }
}
