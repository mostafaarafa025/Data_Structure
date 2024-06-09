using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class QueueuArray
    {
        int[] Array;
        int front;
        int rear;
        public QueueuArray(int size)
        {
            Array = new int[size];
            this.front = -1;
            this.rear = -1;
        }
        public bool isEmpty()
        {
            return (front == -1);
        }
        public bool isFull()
        {
            return (rear == Array.Length - 1);
        }
        public void Enqueue(int value)
        {
            if (isFull())
            {
                Console.WriteLine("queue is full");
                return;
            }
            else if (isEmpty())
            {
                front++;
                rear++;
                Array[front] = value;
            }
            else
            {
                rear++;
                Array[rear] = value;
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
                front++;
            }
        }
        public void getTop()
        {
            if (isEmpty())
                Console.WriteLine("queue is empty");
            else
            {
                int x = Array[front];
                Console.WriteLine(x);
            }
        }

        public void display()
        {
            if (isEmpty())

                Console.WriteLine("queue is empty");
            else
            {
                for (int i = front; i <= rear; i++)
                {
                    int data = Array[i];
                    Console.Write(data + " ");
                }
                Console.WriteLine();
            }


        }
    }
}
