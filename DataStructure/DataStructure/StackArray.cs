using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class StackArray

    {

        int[] MyArray;
        int top;
        int Size;
        public StackArray(int size)
        {
            this.top = -1;
            this.Size = size;
            MyArray = new int[size];

        }
        public void Push(int value)
        {
            if (isFull())
                Console.WriteLine("stack is full");
            else
            {
                top++;
                MyArray[top] = value;
            }
        }
        public void Print()
        {
            if (isEmpty())
                Console.WriteLine("stack is empty");
            else
            {
                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(MyArray[i]);
                }
            }
        }
        public void Pop()
        {
            if (isEmpty())
                Console.WriteLine("stack is empty");
            else
                top--;

        }
        public int GetTop()
        {
            if (isEmpty())
                return -1;
            else
                return MyArray[top];

        }
        public bool isEmpty()
        {
            if (top == -1)
                return true;
            else
                return false;
        }
        public bool isFull()
        {
            if (top == Size - 1)
                return true;
            else
                return false;
        }
    }
}
