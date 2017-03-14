using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

namespace AlgorithmPractice.Tests
{
    [TestClass]
    public class FactorialTests
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Iterative_negative_value_should_throw_exception()
        {
            Factorial.Iterative(-1);
        }

        [TestMethod]
        public void Iterative_should_return_correct_value_for_0()
        {
            Factorial.Iterative(0).Should().Be(1);
        }

        [TestMethod]
        public void Iterative_should_return_correct_value()
        {
            Factorial.Iterative(1).Should().Be(1);
            Factorial.Iterative(5).Should().Be(120);
            Factorial.Iterative(25).Should().Be(7034535277573963776);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Recursive_negative_value_should_throw_exception()
        {
            Factorial.Recursive(-1);
        }

        [TestMethod]
        public void Recursive_should_return_correct_value_for_0()
        {
            Factorial.Recursive(0).Should().Be(1);
        }

        [TestMethod]
        public void Recursive_should_return_correct_value()
        {
            Factorial.Recursive(1).Should().Be(1);
            Factorial.Recursive(5).Should().Be(120);
            Factorial.Recursive(15).Should().Be(1307674368000);
            Factorial.Recursive(25).Should().Be(7034535277573963776);
        }
    }
}
