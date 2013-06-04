namespace _02.Stack_In_Out
{
    using System;
    using System.Collections.Generic;

    /*
     * Write a program that reads N integers from the console 
     * and reverses them using a stack. Use the Stack<int> class.
     */ 

    class Program
    {
        static void Main(string[] args)
        {
            var numberContainer = new Stack<int>();

            while (true)
            {
                string readLine = Console.ReadLine();

                if (readLine == string.Empty)
                {
                    break;
                }

                int parsedNum = 0;

                bool isParsed = int.TryParse(readLine, out parsedNum);

                if (isParsed)
                {
                    if (parsedNum >= 0)
                    {
                        numberContainer.Push(parsedNum);
                    }
                }
            }

            Console.WriteLine(string.Join(" ",numberContainer));
        }
    }
}
