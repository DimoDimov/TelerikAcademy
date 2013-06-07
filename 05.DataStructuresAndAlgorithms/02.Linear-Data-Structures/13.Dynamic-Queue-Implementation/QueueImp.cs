namespace _13.Dynamic_Queue_Implementation
{
    using System;

    class QueueImp<T>
    {
        private QueueNode<T> firstNode { get; set; }
        private QueueNode<T> lastNode { get; set; }
        private int count { get; set; }
        
        public void Enqueue(T value)
        {
            QueueNode<T> newNode = new QueueNode<T>(value);

            if (firstNode == null)
            {
                firstNode = newNode;
                lastNode = firstNode;
            }
            else
            {
                lastNode.NextNode = newNode;
                lastNode = newNode;
            }

            this.count++;
        }

        public T Dequeue()
        {
            if (firstNode == null)
            {
                throw new OperationCanceledException("Can not dequeue queue of null");
            }

            T nodeValue = firstNode.Value;
            firstNode = firstNode.NextNode;
            count--;

            return nodeValue;
        }

        public int Count
        {
            get { return this.count; }
        }

        
    }
}
