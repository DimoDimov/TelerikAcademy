namespace _13.Dynamic_Queue_Implementation
{
    using System;

    /*
     * Implement the ADT queue as dynamic linked list. 
     * Use generics (LinkedQueue<T>) to allow storing different 
     * data types in the queue
     */

    class Program
    {
        static void Main()
        {
            QueueImp<int> myQueue = new QueueImp<int>();

            Console.WriteLine(myQueue.Count);
            myQueue.Enqueue(3);
            Console.WriteLine(myQueue.Dequeue());
            myQueue.Enqueue(4);
            myQueue.Enqueue(7);
            Console.WriteLine(myQueue.Dequeue());
            Console.WriteLine(myQueue.Dequeue());
        }
    }
}
