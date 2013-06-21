namespace _07.FindAllPaths
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /*
     *  Modify the above program to check whether a 
     *  path exists between two cells without finding all 
     *  possible paths. Test it over an empty 100 x 100 matrix.
     */

    class Program
    {
        static char[,] lab = new char[,]{
                                            {' ', ' ', ' ', '*', ' ', ' ', ' '},
                                            {'*', '*', ' ', '*', ' ', '*', ' '},
                                            {' ', ' ', ' ', ' ', ' ', ' ', ' '},
                                            {' ', '*', '*', '*', '*', '*', ' '},
                                            {' ', ' ', ' ', ' ', ' ', ' ', 'e'},
                                        };

        static List<Tuple<int, int>> path = new List<Tuple<int, int>>();

        static void Main()
        {
            int startRow = 0;
            int startCol = 0;

            FindPath(startRow, startCol);
        }
  
        private static void FindPath(int startRow, int StartCol)
        {
            if (!IsInLab(startRow, StartCol))
            {
                
                return;
            }

            if (lab[startRow,StartCol] == '*')
            {
                return;
            }

            if (lab[startRow, StartCol] == 'e')
            {
                path.Add(new Tuple<int, int>(startRow, StartCol));
                Print(path);
                path.RemoveAt(path.Count - 1);
            }

            if (lab[startRow,StartCol] != ' ')
            {
                return;
            }

            path.Add(new Tuple<int, int>(startRow, StartCol));
            lab[startRow, StartCol] = 's';

            FindPath(startRow, StartCol - 1); //left recursively
            FindPath(startRow - 1, StartCol); //up recursively
            FindPath(startRow, StartCol + 1); //right recursively
            FindPath(startRow + 1, StartCol); //down recursively

            lab[startRow, StartCol] = ' ';
            path.RemoveAt(path.Count - 1);
        }

        private static void Print(List<Tuple<int, int>> path)
        {
            Console.WriteLine("the way to exit is: ");
            foreach (var step in path)
            {
                Console.Write("({0}, {1}) ", step.Item1, step.Item2);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
  
        private static bool IsInLab(int row, int col)
        {
            bool rowIsInLab = row >= 0 && row < lab.GetLength(0);
            bool colIsInLab = col >= 0 && col < lab.GetLength(1);

            return rowIsInLab && colIsInLab;
        }
    }
}