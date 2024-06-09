using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class StackLinkedList
    {
        Node top;



        public bool isEmptyy()
        {
            if (top == null)

                return true;
            else
                return false;
        }
        public void push(int x)
        {

            Node node = new Node(x);
            node.next = top;
            top = node;

        }
        public void pop()
        {
            if (isEmptyy())
                Console.WriteLine("stack is empty");
            else
            {
                //Node p = top;
                top = top.next;
            }
        }
        public void display()
        {
            if (isEmptyy())
                Console.WriteLine("stack is empty");
            else
            {
                Node f = top;
                while (f != null)
                {
                    Console.WriteLine(f.data);
                    f = f.next;
                }
            }
        }
        public void peek()
        {
            if (isEmptyy())
                Console.WriteLine("satck is empty");

            else
            {
                int data = top.data;

                Console.WriteLine(data);

            }
        }
        public void peekAndPop()
        {
            if (isEmptyy())
                Console.WriteLine("stack is empty");
            else
            {
                int x = top.data;
                top = top.next;
                Console.WriteLine(x);

            }
        }
        public void sizeOfStack()
        {
            int size = 0;
            if (isEmptyy())
                Console.WriteLine("stack is empty");
            else
            {
                Node s = top;
                while (s != null)
                {
                    size++;
                    s = s.next;

                }
                Console.WriteLine(size);
            }

        }

        public void getMax()
        {
            if (isEmptyy())
            {
                Console.WriteLine("stack is empty");
            }
            else
            {
                int max = top.data;
                Node current = top;

                while (current != null)
                {
                    if (current.data > max)
                    {
                        max = current.data;
                    }
                    current = current.next;
                }

                Console.WriteLine(max);
            }
        }


        public void getMin()
        {

            if (isEmptyy())
                Console.WriteLine("stack is empty");
            else
            {
                int min = top.data;
                Node current = top;
                while (current != null)
                {
                    if (current.data < min)
                    { min = current.data; }
                    current = current.next;
                }
                Console.WriteLine(min);
            }
        }
        public void Sum()
        {
            if (isEmptyy())
                Console.WriteLine("stack is empty");
            else
            {
                int sum = 0;
                Node current = top;
                while (current != null)
                {
                    sum = sum + current.data;
                    current = current.next;
                }
                Console.WriteLine(sum);
            }
        }
        public bool search(int y)
        {
            Node current = top;
            while (current != null)
            {
                if (current.data == y)
                { return true; }
                current = current.next;
            }
            return false;
        }

        public static bool areEqual(StackLinkedList st1, StackLinkedList st2)
        {
            Node current1 = st1.top;
            Node current2 = st2.top;
            while (current1 != null && current2 != null)
            {
                if (current1.data != current2.data)
                { return false; }
                current1 = current1.next;
                current2 = current2.next;
            }
            return true;
        }

        public static void reverse(StackLinkedList st1)
        {
            Node curr = st1.top;
            StackLinkedList tempStack1 = new StackLinkedList();
            while (curr != null)
            {
                int x = curr.data;
                tempStack1.push(x);
                curr = curr.next;
            }
            tempStack1.display();

        }
    }
}
