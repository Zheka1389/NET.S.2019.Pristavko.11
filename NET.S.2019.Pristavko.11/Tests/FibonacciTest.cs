﻿namespace NET.S._2019.Pristavko._11.Tests
{
    using System.Linq;
    using NUnit.Framework;

    [TestFixture]
    internal class FibonacciTest
    {
        [Test]
        [TestCase(6, new int[] { 0, 1, 1, 2, 3, 5 })]
        [TestCase(0, new int[] { })]
        [TestCase(1, new int[] { 0, 1 })]
        [TestCase(21, new int[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765 })]
        public void FibonacciTest_Get_6_Numbers_Succed(int count, int[] expected)
        {
            Assert.IsTrue(Fibonacci.Fibonaccis(count).SequenceEqual(expected));
        }
    }
}
