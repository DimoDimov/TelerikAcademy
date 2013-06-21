namespace _06.PrintSubsetOfStrings
{
    using System;
    using System.Linq;

    /*
     * Write a program for generating and printing all subsets of k strings from given set of strings.
     * Example: s = {test, rock, fun}, k=2
     * (test rock),  (test fun),  (rock fun)
     */

    class Program
    {
        static void Main()
        {
            //int n = int.Parse(Console.ReadLine());
            //int k = int.Parse(Console.ReadLine());
            int n = 3;
            int k = 2;

            string[] set = new string[] { " ", "test", "rock", "fun" };
            string[] variation = new string[k];

            //for (int i = 1; i < n+1; i++)
            //{
            //    set[i] = Console.ReadLine();
            //}

            ProcessVariations(set, variation, 0, 1);
        }

        private static void ProcessVariations(string[] set, string[] variation, int arrIndex, int startIndex)
        {
            if (arrIndex == variation.Length)
            {
                Print(variation);
                return;
            }

            for (int i = startIndex, len = set.Length; i < len; i++)
            {
                    variation[arrIndex] = set[i];

                    ProcessVariations(set, variation, arrIndex + 1, i + 1);
            }
        }

        private static void Print(string[] variation)
        {
            Console.WriteLine("(" + String.Join(" ", variation) + ")");
        }
    }
}
