namespace _05.StringVariations
{
    using System;
    using System.Linq;

    /*
     * Write a recursive program for generating and printing all ordered k-element subsets 
     * from n-element set (variations Vkn).
     * Example: n=3, k=2, set = {hi, a, b} =>
     * (hi hi), (hi a), (hi b), (a hi), (a a), (a b), (b hi), (b a), (b b)
     */

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            string[] set = new string[n + 1];//{" ", "hi", "a", "b"};
            string[] variation = new string[k];


            for (int i = 1; i < n + 1; i++)
            {
                set[i] = Console.ReadLine();
            }

            ProcessVariations(set, variation, 0);
        }

        private static void ProcessVariations(string[] set, string[] variation, int arrIndex)
        {
            if (arrIndex == variation.Length)
            {
                Print(variation);
                return;
            }

            for (int i = 1, len = set.Length; i < len; i++)
            {
                variation[arrIndex] = set[i];
                ProcessVariations(set, variation, arrIndex + 1);
            }
        }

        private static void Print(string[] variation)
        {
            Console.WriteLine("(" + String.Join(" ", variation) + ")");
        }
    }
}
