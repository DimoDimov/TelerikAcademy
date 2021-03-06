﻿namespace Task2
{
    using System;
    using System.Linq;

    /*
     * Task 2
     * What is the expected running time of the
     * following C# code? Explain why.
     * Assume the array's size is n*m.
     */

    public class Program
    {
        public static long CalcCount(int[,] matrix)
        {
            long count = 0;

            //first cycle with n steps
            for (int row = 0; row < matrix.GetLength(0); row++)
                //second cycle with 0 to m steps depending on variable that varies from (0-1)*m steps
                if (matrix[row, 0] % 2 == 0)
                    //second cycle dependable on the above condition.
                    for (int col = 0; col < matrix.GetLength(1); col++)
                        if (matrix[row, col] > 0)
                            count++;
            return count;
        }

        /*
         * The complexity of the algorithm(worst scenario) is: O(n * m)
         * Once we cycle through the whole array with length n.
         * Secondary we go through a second cycle which contains (m) steps.
         * The second cycle depends on variable parameter a. 
         * After we remove the parameter we have the following complexity: 0(n*m)
         */

        public static void Main(string[] args)
        {
            int[,] testMatrix = new int[,] 
            { 
                {1, 2, 4, -19, 23, -44, -45},
                {16, 22, 14, -9, -23, 44, 45},
                {7, 9, 14, -11, 233, -45, 45},
            };

            Console.WriteLine(CalcCount(testMatrix));
        }
    }
}
