namespace _03.CombinationsWithDuplicates
{
    using System;
    using System.Linq;

    /*
     * Write a recursive program for generating and printing all the combinations 
     * with duplicates of k elements from n-element set. Example:
     * n=3, k=2  (1 1), (1 2), (1 3), (2 2), (2 3), (3 3)
     */

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] variation = new int[k];

            ProcessNestedLoops(variation, 0, n);
        }

        private static void ProcessNestedLoops(int[] variation, int arrIndex, int endIndex)
        {
            if (arrIndex == variation.Length)
            {
                Print(variation);
                return;
            }

            for (int i = 1; i <= endIndex; i++)
            {
                variation[arrIndex] = i;
                ProcessNestedLoops(variation, arrIndex + 1, endIndex);
            }
        }

        private static void Print(int[] variation)
        {
            Console.WriteLine("(" + String.Join(",", variation) + ")");
        }
    }
}
