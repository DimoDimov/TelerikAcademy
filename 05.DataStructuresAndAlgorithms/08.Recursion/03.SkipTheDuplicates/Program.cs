namespace _03.SkipTheDuplicates
{
    using System;
    using System.Linq;

    /*
     * Modify the previous program to skip duplicates:
     * n=4, k=2  (1 2), (1 3), (1 4), (2 3), (2 4), (3 4)
     */

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] variation = new int[k];
            ProcessNestedLoops(variation, 0, 1, n);
        }

        private static void ProcessNestedLoops(int[] variation, int arrIndex, int currIndex, int endIndex)
        {
            if (arrIndex == variation.Length)
            {
                Print(variation);
                return;
            }

            for (int i = currIndex; i <= endIndex; i++)
            {
                variation[arrIndex] = i;
                ProcessNestedLoops(variation, arrIndex + 1, i + 1, endIndex);
            }
        }

        private static void Print(int[] variation)
        {
            Console.WriteLine("(" + String.Join(",", variation) + ")");
        }
    }
}
