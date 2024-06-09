using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class Node
    {
        public int data;
        public Node next;

        public Node(int x)
        {
            this.data = x;
            this.next = null;
        }
    }
}
