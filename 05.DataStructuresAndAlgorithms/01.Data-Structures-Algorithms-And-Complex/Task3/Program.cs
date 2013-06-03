namespace Task3
{
    using System;
    using System.Linq;

    /*
     * Task 3
     * What is the expected running time of the
     * following C# code? Explain why.
     * Assume the array's size is n*m.
     */

    public class Program
    {
        public static long CalcSum(int[,] matrix, int row)
        {
            long sum = 0;

            //corrected here. Original code used to be col < matrix.GetLength(0)
            //I have changed it because the matrix columns are being represented 
            //by matrix.GetLength(1) value
            //We run m steps through the columns of the matrix
            for (int col = 0; col < matrix.GetLength(1); col++)
                sum += matrix[row, col];
            //corrected here. Original code used to be col < matrix.GetLength(1)
            //I have changed it because the matrix rows are being represented 
            //by matrix.GetLength(0) value
            //We run n steps recursively through the rows
            if (row + 1 < matrix.GetLength(0))
                sum += CalcSum(matrix, row + 1);

            return sum;
        }

        /*
         * The complexity of the algorithm(worst scenario) is: O(n * m)
         * We run recursively through each of the rows of the matrix which is (n-row) steps
         * We run through the columns which is m steps.
         */


        public static void Main(string[] args)
        {
            int[,] testMatrix = new int[,] 
            { 
                {1, 2, 4, -19, 23, -44, -45},
                {16, 22, 14, -9, -23, 44, 45},
                {7, 9, 14, -11, 233, -45, 45},
            };

            int row = 0;
            Console.WriteLine(CalcSum(testMatrix, row));
        }
    }
}
