namespace _12.AutoResizable_Stack
{
    using System;
    using System.Linq;
    
    class StackImplementaton<T>
    {
        private T[] storage;
        private int count;
        

        public int Count
        {
            get 
            {
                return this.count; 
            }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The count can not be negative");
                }

                this.count = value; 
            }
        }

        public StackImplementaton()
        {
            this.storage = new T[2];
            this.Count = 0;
        }

        public int Capacity()
        {
            return this.storage.Count();
        }

        public void Push(T newEl)
        {
            if (this.count == this.storage.Length)
            {
                DoubleTheStorage();
            }

            this.storage[this.Count] = newEl;
            this.count += 1;
        }

        public T Peek()
        {
            if (this.Count == 0)
            {
                throw new ArgumentNullException("The storage is empty");
            }
            T value = this.storage[this.Count - 1];

            return value;
        }

        public T Pop()
        {
            if (this.Count==0)
            {
                throw new ArgumentNullException("The storage is empty");
            }
            T value = this.storage[this.Count - 1];
            this.Count -= 1;

            return value;
        }

        public bool Contains(T value)
        {
            bool isContaining = false;

            for (int i = 0; i < this.Count; i++)
            {
                if (this.storage[i].Equals(value))
                {
                    isContaining = true;
                    break;
                }
            }

            return isContaining;
        }

        public T[] ToArray()
        {
            T[] newArray = new T[this.Count];
            for (int i = 0; i < this.Count; i++)
            {
                newArray[i] = this.storage[i];
            }

            return newArray;
        }

        public void TrimExcess()
        {
            T[] newArray = new T[this.Count];
            for (int i = 0; i < this.Count; i++)
            {
                newArray[i] = this.storage[i];
            }

            this.storage = newArray;
        }


        private void DoubleTheStorage()
        {
            T[] newDoubleStorage = new T[this.storage.Length * 2];

            for (int i = 0; i < this.storage.Length; i++)
            {
                newDoubleStorage[i] = this.storage[i];
            }

            this.storage = newDoubleStorage;
        }
    }
}
