namespace Task1
{
    using System;
    using System.Linq;

/*
 * Task 1
 * What is the expected running time of the
 * following C# code? Explain why.
 * Assume the array's size is n.
 */

    public class Program
    {
        public static long Compute(int[] arr)
        {
            long count = 0;

            // first cycle n steps
            for (int i = 0; i < arr.Length; i++) 
            {
                int start = 0, end = arr.Length - 1;
                //second cycle n-1 steps
                while (start < end) 
                {
                    if (arr[start] < arr[end])
                    {
                        start++;
                        count++;
                    }
                    else
                    {
                        end--;
                    }
                }
            }
            return count;
        }

        /*
         * The complexity of the algorithm is: O(n * n)
         * Once we cycle through the whole array with length n.
         * Secondary we go through a while cycle which contains (n-1) steps.
         */

        public static void Main(string[] args)
        {
            int[] testArray = new int[] { 1, -24, 4, -19, -23, -44};
            Console.WriteLine(Compute(testArray));
        }
    }
}
