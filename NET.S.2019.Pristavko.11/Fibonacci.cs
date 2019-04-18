namespace NET.S._2019.Pristavko._11
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Provides method for generate a sequence of numbers of fibonacci.
    /// </summary>
    internal class Fibonacci
    {
        /// <summary>
        /// Generates a sequence of numbers of fibonacci.
        /// </summary>
        /// <returns>A sequence of numbers of fibonacci.</returns>
        public static IEnumerable<int> Fibonaccis(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException("The number cannot be less than zero ", nameof(number));
            }

            if (number == 0)
            {
                return new List<int> { };
            }

            var fibonacciNumbers = new List<int> { 0, 1 };
            for (int i = fibonacciNumbers.Count; i < number; i++)
            {
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
                fibonacciNumbers.Add(previous + previous2);
            }

            return fibonacciNumbers;
        }
    }
}
