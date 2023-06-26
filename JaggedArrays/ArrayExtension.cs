using System;
using System.Collections.Generic;

namespace JaggedArrays
{
    public static class ArrayExtension
    {
        /// <summary>
        /// Orders the rows in a jagged-array by ascending of the sum of the elements in them.
        /// </summary>
        /// <param name="source">The jagged-array to sort.</param>
        /// <exception cref="ArgumentNullException">Thrown when source in null.</exception>
        public static void OrderByAscendingBySum(this int[][] source)
        { 
            int[] result = SumOfSting(source);
            SortToUp(source, result);            
        }

        /// <summary>
        /// Orders the rows in a jagged-array by descending of the sum of the elements in them.
        /// </summary>
        /// <param name="source">The jagged-array to sort.</param>
        /// <exception cref="ArgumentNullException">Thrown when source in null.</exception>
        public static void OrderByDescendingBySum(this int[][] source)
        {
            int[] result = SumOfSting(source);
            SortToDown(source, result);
        }

        /// <summary>
        /// Orders the rows in a jagged-array by ascending of the max of the elements in them.
        /// </summary>
        /// <param name="source">The jagged-array to sort.</param>
        /// <exception cref="ArgumentNullException">Thrown when source in null.</exception>
        public static void OrderByAscendingByMax(this int[][] source)
        {
            int[] result = MaxElementsInString(source);
            SortToUp(source, result);
        }

        /// <summary>
        /// Orders the rows in a jagged-array by descending of the max of the elements in them.
        /// </summary>
        /// <param name="source">The jagged-array to sort.</param>
        /// <exception cref="ArgumentNullException">Thrown when source in null.</exception>
        public static void OrderByDescendingByMax(this int[][] source)
        {
            int[] result = MaxElementsInString(source);
            SortToDown(source, result);
        }

        private static int[] SumOfSting(int[][] source)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            int[] result = new int[source.Length];
            for (int i = 0; i < source.Length; i++)
            {
                int sum = 0;
                if (source[i] != null)
                {
                    for (int j = 0; j < source[i].Length; j++)
                    {
                        sum += source[i][j];
                    }
                }

                result[i] = sum;
            }

            return result;
        }

        private static void SortToUp(int[][] source, int[] result)
        {
            for (int x = 0; x < result.Length; x++)
            {
                for (int y = x + 1; y < result.Length; y++)
                {
                    if (result[x] > result[y])
                    {
                        int[] temp = source[x];
                        source[x] = source[y];
                        source[y] = temp;
                        int temp2 = result[x];
                        result[x] = result[y];
                        result[y] = temp2;
                    }
                }
            }
        }

        private static void SortToDown(int[][] source, int[] result)
        {
            for (int x = 0; x < result.Length; x++)
            {
                for (int y = x + 1; y < result.Length; y++)
                {
                    if (result[x] < result[y])
                    {
                        int[] temp = source[x];
                        source[x] = source[y];
                        source[y] = temp;
                        int temp2 = result[x];
                        result[x] = result[y];
                        result[y] = temp2;
                    }
                }
            }
        }

        private static int[] MaxElementsInString(int[][] source)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            int[] result = new int[source.Length];
            for (int i = 0; i < source.Length; i++)
            {
                int maxElement = -1;
                if (source[i] != null)
                {
                    for (int j = 0; j < source[i].Length; j++)
                    {
                        bool max = true;
                        for (int k = 0; k < source[i].Length; k++)
                        {
                            if (source[i][j] < source[i][k])
                            {
                                max = false;
                            }
                        }

                        if (max)
                        {
                            maxElement = source[i][j];
                        }
                    }
                }

                result[i] = maxElement;
            }

            return result;
        }
    }
}
