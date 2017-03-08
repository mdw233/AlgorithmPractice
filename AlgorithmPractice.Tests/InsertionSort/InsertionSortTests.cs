using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmPractice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using System.Diagnostics;

namespace AlgorithmPractice.Tests
{
    [TestClass]
    public class InsertionSortTests
    {
        [TestMethod]
        public void Run_should_not_fail_on_empty_array()
        {
            var array = new int[] { };
            var result = InsertionSort.Run(array);

            array.Should().NotBeNull();
            array.Should().BeEmpty();
        }

        [TestMethod]
        public void Run_should_not_fail_on_single_element_array()
        {
            var array = new int[] { 50 };
            var result = InsertionSort.Run(array);

            array.Length.Should().Be(1);
            array[0].Should().Be(50);
        }

        [TestMethod]
        public void Run_should_not_fail_when_the_same_value_appears_multiple_times()
        {
            var array = new int[] { 50, 3, 25, 3, 40, 3 };
            var result = InsertionSort.Run(array);

            array.SequenceEqual(new int[] { 3, 3, 3, 25, 40, 50 }).Should().BeTrue();
        }

        [TestMethod]
        public void Run_should_sort_array()
        {
            var array = new int[] { 50, 430, 1, 3, 9, 2, 34, 100, 440, 430, 21 };
            var result = InsertionSort.Run(array);

            array.SequenceEqual(new int[] { 1, 2, 3, 9, 21, 34, 50, 100, 430, 430, 440 }).Should().BeTrue();
        }
        
        [TestMethod]
        public void Iterations_timing()
        {
            var msToComplete = RunIterationsTiming(10000);
            Trace.Write($"{10000} iterations took {msToComplete}ms to SelectionSort");

            msToComplete = RunIterationsTiming(100000);
            Trace.Write($"{100000} iterations took {msToComplete}ms to SelectionSort");
        }

        private object RunIterationsTiming(int arraySize)
        {
            var array = new int[arraySize];
            var rand = new Random();
            for (var i = 0; i < arraySize; i++)
            {
                array[i] = rand.Next(1000);
            }

            var stopWatch = new Stopwatch();
            stopWatch.Start();
            InsertionSort.Run(array);
            stopWatch.Stop();

            return stopWatch.ElapsedMilliseconds;
        }
    }
}