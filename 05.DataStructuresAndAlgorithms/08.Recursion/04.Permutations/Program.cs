namespace _04.Permutations
{
    using System;
    using System.Linq;

    /*
     * Write a recursive program for generating and printing 
     * all permutations of the numbers 1, 2, ..., n for 
     * given integer number n. Example:
     * 
     * n=3  {1, 2, 3}, {1, 3, 2}, {2, 1, 3},			
     *       {2, 3, 1}, {3, 1, 2},{3, 2, 1}
     */

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] permutation = new int[n];
            
            //memoization in additional array
            bool[] usedNum = new bool[n+1];

            ProcessNestedLoops(permutation, 0, usedNum);
        }

        private static void ProcessNestedLoops(int[] permutation, int arrIndex, bool[] usedNum)
        {
            if (arrIndex == permutation.Length)
            {
                Print(permutation);
                return;
            }

            for (int i = 1, len = permutation.Length; i <= len; i++)
            {
                if (!usedNum[i])
                {
                    permutation[arrIndex] = i;
                    usedNum[i] = true;
                    ProcessNestedLoops(permutation, arrIndex + 1, usedNum);
                    usedNum[i] = false;
                }
                
            }
        }

        private static void Print(int[] permutation)
        {
            Console.WriteLine("(" + String.Join(",", permutation) + ")");
        }
    }
}
