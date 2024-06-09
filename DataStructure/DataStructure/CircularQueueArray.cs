using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class CircularQueueArray
    {
        int front;
        int rear;
        int[] Array;
        int Size;
        public CircularQueueArray(int size)
        {
            this.Size = size;
            this.Array = new int[Size];
            this.front = -1;
            this.rear = -1;
        }
        public bool isEmpty()
        {
            return front == -1;
        }
        public bool isFull()
        {
            return (rear + 1) % Size == front;
        }
        public void enqueue(int item)
        {
            if (isFull())
            {
                Console.WriteLine("queue is full");
                return;
            }
            else if (isEmpty())
            {
                front = (front + 1) % Size;
                rear = (rear + 1) % Size;
                Array[front] = item;

            }
            else
            {
                rear = (rear + 1) % Size;
                Array[rear] = item;
            }

        }
        public void dequeue()
        {
            if (isEmpty())
                Console.WriteLine("queue is empty");
            else if (front + 1 > rear)
            {
                front = -1;
                rear = -1;
                Console.WriteLine("queue is reset");
            }
            else
            {
                front = (front + 1) % Size;
            }
        }
        public void display()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue is empty");
                return;
            }

            int i = front;
            while (true)
            {
                Console.Write(Array[i] + " ");
                if (i == rear)
                {
                    break;
                }
                i = (i + 1) % Size;
            }
            Console.WriteLine();
        }


    }
}
