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
            get{return this.count == 0}
        }

        public int Count
        {
            get { return this.count; }
        }
    }
}
