using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLst
{
    public class Node
    {
        /* Constructor:
         * [ ] Node(object data, Node next)
         * 
         * Private Fields:
         * [ ] object data - contain the data of the node, what we want to store in the list
         * [ ] Node next - reference to the next node in the list
         * 
         * Public Properties:
         * [ ] Data - get/set the data field
         * [ ] next - get/set the next field
         */

        private object data;
        private Node next;

        public Node(object data, Node next)
        {
            this.data = data;
            this.next = next;
        }

        public object Data
        {
            get { return this.data; }
            set { this.data = value; }
        }

        public Node Next
        {
            get { return this.next; }
            set { this.next = value; }
        }
    }
}
