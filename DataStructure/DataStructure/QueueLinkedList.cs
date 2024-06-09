using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class QueueLinkedList
    {
        Node front;
        Node rear;

        public bool isEmpty()
        {
            return (front == null);
        }
        public void enqueue(int data)
        {
            Node p = new Node(data);
            if (front == null)
            {
                front = rear = p;
                return;
            }
            rear.next = p;
            rear = p;
        }
        public void dequeue()
        {
            if (isEmpty())
            {
                Console.WriteLine("queue is empty");
                return;
            }


            front = front.next;
            if (front == null)
                rear = null;
        }
        public void display()
        {
            if (isEmpty())
            { Console.WriteLine("queue is empty"); }
            Node current = front;
            while (current != null)
            {
                Console.Write(current.data + " ");
                current = current.next;
            }
            Console.WriteLine();
        }
        public void getTop()
        {
            if (isEmpty())
            { Console.WriteLine("queue is empty"); }
            else
            {
                Console.WriteLine(front.data);
            }
        }

        public void getMax()
        {
            int max = front.data;
            Node curr = front;
            while (curr != null)
            {
                if (curr.data > max)
                { max = curr.data; }
                curr = curr.next;
            }
            Console.WriteLine(max);
        }
        public void getMin()
        {
            int min = front.data;
            Node curr = front;
            while (curr != null)
            {
                if (curr.data < min)
                {
                    min = curr.data;
                }
                curr = curr.next;
            }
            Console.WriteLine(min);
        }
        public void getSize()
        {
            if (isEmpty())
            {
                Console.WriteLine("queue is empty");
                return;
            }
            int size = 0;
            Node curr = front;
            while (curr != null)
            {
                size++;
                curr = curr.next;
            }
            Console.WriteLine(size);
        }
        public void getSum()
        {
            int sum = 0;
            Node curr = front;
            while (curr != null)
            {
                sum = sum + curr.data;
                curr = curr.next;
            }
            Console.WriteLine(sum);
        }
        public bool search(int value)
        {
            Node curr = front;
            while (curr != null)
            {
                if (curr.data == value)
                { return true; }
                curr = curr.next;
            }
            return false;
        }
        public static bool isEqual(QueueLinkedList q1, QueueLinkedList q2)
        {
            Node curr1 = q1.front;
            Node curr2 = q2.front;
            while (curr1 != null && curr2 != null)
            {
                if (curr1.data != curr2.data)
                { return false; }
                curr1 = curr1.next;
                curr2 = curr2.next;
            }
            return true;
        }
    }
}
