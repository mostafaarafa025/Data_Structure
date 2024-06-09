using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class LinkedList
    {
        public Node head;
        public Node tail;


        public bool isEmpty()
        {
            return (head == null);
        }
        public void insertFirst(int value)
        {
            Node p = new Node(value);
            if (isEmpty())
            {
                head = p;
                tail = p;
            }
            else
            {
                p.next = head;
                head = p;
            }
        }
        public void insertLast(int value)
        {
            Node p = new Node(value);
            if (isEmpty())
            {
                head = p;
                tail = p;
            }
            else
            {
                tail.next = p;
                tail = p;
            }
        }
        public void Display()
        {
            if (isEmpty())
                Console.WriteLine("linked list is empty");
            else
            {
                Node current = head;
                while (current != null)
                {
                    Console.Write(current.data + " ");
                    current = current.next;
                }
                Console.WriteLine();
            }
        }
        public int getSize()
        {
            int ctr =0 ;
            if (isEmpty())
                return 0;
            else
            {
                Node current = head;
                while (current != null)
                {
                    ctr++;
                    current = current.next;
                }
                return ctr;
            }
        }

        public void insertPos(int value, int pos)
        {
            int c = getSize();
            if (pos == 0)
            { insertFirst(value); }

            else if (pos == c)
            { insertLast(value); }
            else if (pos < 0 || pos > c)
                Console.WriteLine("the number is out of list");
            else
            {

                Node current = head;
                for (int i = 0; i < pos - 1; i++)
                {
                    current = current.next;
                }
                Node p = new Node(value);
               p.next=current.next;
                current.next = p;
            }
        }
        public void search(int x)
        {
            if (isEmpty())
                Console.WriteLine("list is empty");
            else
            {
                Node current = head;
                while (current != null)
                {
                    if (current.data == x)
                    {
                        Console.WriteLine("exist");
                        return;

                    }
                    current = current.next;
                }
                Console.WriteLine("doesn't exist");
                return;
            }
        }
        public void deleteFirst()
        {
            if (isEmpty())
                Console.WriteLine("list is empty");
            else
            {
                int x = head.data;
                head = head.next;
                Console.WriteLine("the deleted number is " + x);
            }
        }
        public void deleteLast()
        {
            if (isEmpty())
                Console.WriteLine("the list is empty");
            else if (head == tail)
            {
               deleteFirst();
            }
            else
            {
                Node curr = head;
                while (curr.next != tail)
                {
                    curr = curr.next;
                }
                Console.WriteLine("the deleted number is " + tail.data);
                curr.next = null;
                tail = curr;
            }
        }
        public void deletePos(int pos)
        {
            int size = getSize();
            if (pos == 0)
                deleteFirst();
            else if (pos == size - 1)
                deleteLast();
            else if (pos < 0 || pos >= size)
                Console.WriteLine("the number is out of list ");
            else
            {
                Node curr = head;
                for (int i = 0; i < pos - 1; i++)
                {
                    curr = curr.next;
                }
                Node temp = curr.next;
                curr.next = temp.next;
                Console.WriteLine("the deleted number is " + temp.data);
                temp = null;

            }
        }
        public void insertSorted(int value)
        {
            
            if (isEmpty() || head.data >= value)
            { insertFirst(value);

            }

            else if (value >= tail.data)
            {
                insertLast(value);
              
            }

            else
            {
                Node current = head;
                while ( current.next.data < value)
                {
                    current = current.next;
                }
                Node newNode = new Node(value);
                newNode.next = current.next;
                current.next = newNode;
              
            }
        }
        public void reverseList()
        {
            if (isEmpty())
                Console.WriteLine("list is empty");
            else
            {
                Node prev, curr, next;
                prev=null;
                curr=head;
                next=head.next;
                while(next!=null)
                {
                    next=curr.next;
                    curr.next=prev;
                    prev = curr;
                    curr = next;
                }
                head=prev;
            }
        }

    }
}
