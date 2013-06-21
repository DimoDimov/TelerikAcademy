namespace _01.NestedLoops
{
    using System;
    using System.Linq;

    /*
     * Write a recursive program that simulates the execution of n nested loops from 1 to n. Examples:
     * 
     *          1 1           
     * n=2  ->  1 2
     *          2 1 
     *          2 2
     */

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] variation = new int[n];
 
            ProcessNestedLoops(variation, 0);
        }

        private static void ProcessNestedLoops( int[] variation, int arrIndex)
        {
            if (arrIndex == variation.Length)
            {
                Print(variation);
                return;
            }

            for (int i = 1, len = variation.Length; i <= len; i++)
            {
                variation[arrIndex] = i;
                ProcessNestedLoops(variation, arrIndex + 1);
            }
        }

        private static void Print(int[] variation)
        {
            Console.WriteLine("(" + String.Join(",", variation) + ")");
        }
    }
}
