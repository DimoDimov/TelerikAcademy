namespace _13.Dynamic_Queue_Implementation
{
    using System;
    using System.Collections;

    class QueueNode<T>
    {
        private T value;
        private QueueNode<T> nextNode;

        public T Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        public QueueNode<T> NextNode
        {
            get { return this.nextNode; }
            set { this.nextNode = value; }
        }

        public QueueNode(T value)
        {
            this.Value = value;  
        }

    }
}
