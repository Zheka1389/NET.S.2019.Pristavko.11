namespace NET.S._2019.Pristavko._11
{
    using System;
    using System.Collections;

    internal class BinarrySearch
    {
        public static int Search<T>(T[] array, T value) 
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            Comparer comparer = Comparer.Default;
            var left = 0;
            var right = array.Length - 1;
            if (left == right)
            {
                return left;
            }

            while (true)
            {
                if (right - left == 1)
                {
                    if (comparer.Compare(array[left], value) == 0)
                    {
                        return left;
                    }

                    if (comparer.Compare(array[right], value) == 0)
                    {
                        return right;
                    }

                    return -1;
                }
                else
                {
                    var middle = left + ((right - left) / 2);
                    int comparisonResult = comparer.Compare(array[middle], value);
                    if (comparisonResult == 0)
                    {
                        return middle;
                    }

                    if (comparisonResult < 0)
                    {
                        left = middle;
                    }

                    if (comparisonResult > 0)
                    {
                        right = middle;
                    }
                }
            }
        }
    }
}
