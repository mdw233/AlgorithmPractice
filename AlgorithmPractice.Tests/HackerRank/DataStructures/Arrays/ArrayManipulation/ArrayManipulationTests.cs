using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.Tests.HackerRank.DataStructures.Arrays.ArrayManipulation
{
    [TestClass]
    public class ArrayManipulationTests : TestBase
    {
        [TestMethod]
        public void the_simple_case_should_work_fine()
        {
            var input = GetFileContent(@"HackerRank\DataStructures\Arrays\ArrayManipulation\input1.txt");
            var answer = new AlgorithmPractice.HackerRank.DataStructures.Arrays.ArrayManipulation.ArrayManipulation(input).Solve();

            answer[0].Should().Be("200");
        }

        [TestMethod]
        public void the_simple_case_should_work_fine_when_using_non_optimal_solution()
        {
            var input = GetFileContent(@"HackerRank\DataStructures\Arrays\ArrayManipulation\input1.txt");
            var answer = new AlgorithmPractice.HackerRank.DataStructures.Arrays.ArrayManipulation.ArrayManipulationNotOptimal(input).Solve();

            answer[0].Should().Be("200");
        }

        [TestMethod]
        public void the_data_intensive_case_should_work_fine()
        {
            var input = GetFileContent(@"HackerRank\DataStructures\Arrays\ArrayManipulation\input2.txt");
            var answer = new AlgorithmPractice.HackerRank.DataStructures.Arrays.ArrayManipulation.ArrayManipulation(input).Solve();

            answer[0].Should().Be("2497169732");
        }

        [TestMethod, Timeout(3000)]
        public void the_data_intensive_case_should_timeout_when_using_non_optimal_solution()
        {
            //todo: do this async, test for the timeout

            var input = GetFileContent(@"HackerRank\DataStructures\Arrays\ArrayManipulation\input2.txt");
            var answer = new AlgorithmPractice.HackerRank.DataStructures.Arrays.ArrayManipulation.ArrayManipulationNotOptimal(input).Solve();

            answer[0].Should().Be("2497169732");
        }
    }
}
