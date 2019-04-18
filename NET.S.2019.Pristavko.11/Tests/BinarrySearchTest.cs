namespace NET.S._2019.Pristavko._11.Tests
{
    using NUnit.Framework;

    [TestFixture]
    internal class BinarrySearchTest
    {
        [TestCase(2, new int[] { 0, 1, 2, 3 }, ExpectedResult = 2)]
        [TestCase(33, new int[] { 0, 1, 2, 3, 31, 33, 234, 242 }, ExpectedResult = 5)]
        [TestCase(277, new int[] { 0, 1, 32, 34, 223, 244, 245, 277 }, ExpectedResult = 7)]
        public static int BinarySearchsInt(int number, int[] arrayNumbers)
        {
            return BinarrySearch.Search(arrayNumbers, number);
        }

        [TestCase(3d, new double[] { 0, 1.4, 2.2, 3, 3.4 }, ExpectedResult = 3)]
        [TestCase(34d, new double[] { 1, 2.7, 3.5, 5, 34, 435.4 }, ExpectedResult = 4)]
        public static int BinarySearchsDouble(double number, double[] arrayNumbers)
        {
            return BinarrySearch.Search(arrayNumbers, number);
        }

        [TestCase('a', new char[] { 'a', 'b', 'c' }, ExpectedResult = 0)]
        [TestCase('c', new char[] { 'a', 'b', 'c' }, ExpectedResult = 2)]
        public static int BinarySearchs(char number, char[] arrayNumbers)
        {
            return BinarrySearch.Search(arrayNumbers, number);
        }
    }
}
