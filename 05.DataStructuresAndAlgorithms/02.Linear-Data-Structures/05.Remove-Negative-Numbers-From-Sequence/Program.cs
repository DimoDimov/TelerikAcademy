namespace _05.Remove_Negative_Numbers_From_Sequence
{
    using System;
    using System.Collections.Generic;

    /*
     * Write a program that removes from given sequence 
     * all negative numbers.
     */

    class Program
    {
        static void Main()
        {
            //Console.WriteLine("Please input the sequence of integers separated by an interval: ");
            //string line = Console.ReadLine();

            string line =
                "3 4 -5 6 -7 7 -7 8 9 9 -9 9";

            string[] elements = line.Split(' ');

            LinkedList<int> unsortedList = new LinkedList<int>();

            foreach (string el in elements)
            {
                unsortedList.AddLast(int.Parse(el));
            }

            Console.WriteLine("The list before removing all negative elements");
            Console.WriteLine(string.Join(", ", unsortedList));

            var node = unsortedList.First;

            while (node != null)
            {
                var next = node.Next;

                if (node.Value < 0)
                    unsortedList.Remove(node);

                node = next;
            }

            Console.WriteLine("\nThe list after removing all negative elements");
            Console.WriteLine(string.Join(", ", unsortedList));
        }
    }
}
