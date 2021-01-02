using System;

namespace BinarySearchTask
{
    /// <summary>
    /// Class for basic array operations.
    /// </summary>
    public static class ArrayExtension
    {
        /// <summary>
        /// Implements binary search, see https://en.wikipedia.org/wiki/Binary_search_algorithm.
        /// </summary>
        /// <param name="source">Source sorted array.</param>
        /// <param name="value">Value to search.</param>
        /// <returns>
        /// The position of an element with a given value in sorted array.
        /// If element is not found returns null.
        /// </returns>
        /// <exception cref="ArgumentNullException">Thrown when array is null.</exception>
        /// <example>
        /// source = {1, 3, 4, 6, 8, 9, 11}, value = 11 => 6,
        /// source = {1, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 634}, value = 144 => 9,
        /// source = {1, 3, 4, 6, 8, 9, 11}, value = 0 => null,
        /// source = {1, 3, 4, 6, 8, 9, 11}, value = 14 => null.
        /// source = { }, value = 14 => null.
        /// </example>
        public static int? BinarySearch(int[] source, int value)
        {
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            int i = 0;
            int length = source.Length - 1;

            while (i <= length)
            {
                int j = (i + length) / 2;

                if (value == source[j])
                {
                    return j;
                }
                else if (value > source[j])
                {
                    i = j + 1;
                }
                else
                {
                    length = j - 1;
                }
            }

            return null;
        }
    }
}
