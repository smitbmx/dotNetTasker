using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLst
{
    public class LinkedList
    {
        /* Constructor:
         * [x] LinkedList() - Initializes the private fields
         * 
         * Private Fields:
         * [x] Node head - Is a reference to the FIRST node in the list
         * [x] int count - The current size of the list
         * 
         * Public Properties:
         * [x] IsEmpty - If the list is empty
         * [x] Count - How many items are in the list
         * [ ] Indexer - Access data like an array.
         * 
         * Methods:
         * [ ] Add(int index, object o) - Add an item to list at specified index
         * [ ] Add(object o) - Add an item to the END of the list
         * [ ] Remove(int index) - Remove the item in the list at the specified index
         * [ ] Clear() - Clear the list
         * [ ] IndexOf(int object o) - gets the index of the item in the list, if not in the list return -1
         * [ ] Contains(object o) - if the list contains the object
         * [ ] Get(int index) - Gets item at the specified index 
         */

        private Node head;
        private int count;

        public LinkedList()
        {
            this.head = null;
            this.count = 0;
        }

        public bool IsEmpty
        {
            get { return this.count == 0; }
        }

        public int Count
        {
            get { return this.count; }
        }

        public object this[int index]
        {
            get { return this.Get(index); }
        }

        public object Add(int index, object o)
        {
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException("index: " + index);
            }

            if (index > count)
            {
                index = count;
            }

            Node current = this.head;

            if (this.IsEmpty || index == 0)
            {
                this.head = new Node(o, this.head);
            }
            else
            {
                for (int i = 0; i < index - 1; i++)
                {
                    current = current.Next;
                }

                current.Next = new Node(o, current.Next);
            }

            count++;

            return o;
        }

        public object Add(object o)
        {
            return this.Add(count, o);
        }

        public object Remove(int index)
        {
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException("index: " + index);
            }

            if (this.IsEmpty)
            {
                return null;
            }

            if (index >= this.count)
            {
                index = count - 1;
            }

            Node current = this.head;
            object result = null;

            if (index == 0)
            {
                result = current.Data;
                this.head = current.Next;
            }
            else
            {
                for (int i = 0; i < index - 1; i++)
                {
                    current = current.Next;
                }

                result = current.Next.Data;

                current.Next = current.Next.Next;
            }

            count--;

            return result;
        }

        public void Clear()
        {
            head.Next = null;
            count = 0;
        }

        public int IndexOf(object o)
        {
            Node current = this.head;

            for (int i = 0; i < count; i++)
            {
                if (current.Data.Equals(o))
                {
                    return i;
                }

                current = current.Next;
            }

            return -1;
        }

        public bool Contains(object o)
        {
            return this.IndexOf(o) >= 1;
        }

        public object Get(int index)
        {
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException("Index: " + index);
            }

            if (this.IsEmpty)
            {
                return null;
            }

            if (index >= count)
            {
                index = this.count - 1;
            }

            Node currentNode = this.head;

            for (int i = 0; i < index; i++)
            {
                currentNode = currentNode.Next;
            }

            return currentNode.Data;
        }
    }
}
