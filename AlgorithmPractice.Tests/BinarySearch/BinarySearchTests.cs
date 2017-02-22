using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

namespace AlgorithmPractice.Tests
{
    [TestClass]
    public class BinarySearchTests
    {
        int[] _array = new[] { 1, 3, 5, 7, 9 };

        [TestMethod]
        public void BinarySearch_should_return_neg1_when_no_match_exists()
        {
            var result = AlgorithmPractice.BinarySearch.Run(_array, 11);

            result.Should().Be(-1);
        }

        [TestMethod]
        public void BinarySearch_should_return_correct_value_when_matching_the_first_element()
        {
            var array = new[] { 1, 3, 5, 7, 9 };
            var result = AlgorithmPractice.BinarySearch.Run(_array, 1);

            result.Should().Be(0);
        }

        [TestMethod]
        public void BinarySearch_should_return_correct_value_when_matching_the_last_element()
        {
            var array = new[] { 1, 3, 5, 7, 9 };
            var result = AlgorithmPractice.BinarySearch.Run(_array, 9);

            result.Should().Be(4);
        }

        [TestMethod]
        public void BinarySearch_should_return_correct_value_when_matching_element_in_the_middle_somewhere()
        {
            var array = new[] { 1, 3, 5, 7, 9, 13, 17 };
            var result = AlgorithmPractice.BinarySearch.Run(_array, 5);

            result.Should().Be(2);
        }
    }
}
