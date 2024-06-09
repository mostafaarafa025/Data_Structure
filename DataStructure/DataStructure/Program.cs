using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("enter your size ");
            //int size = int.Parse(Console.ReadLine());
            //StackArray st = new StackArray(size);
            //Console.WriteLine("-------------");
            //st.Push(20);
            //st.Push(300);
            //st.Push(40);
            //st.Push(50);
            //st.Push(80);
            //st.Print();
            //Console.WriteLine(st.isFull());
            //st.Pop();
            //st.Pop();                                         //stack Array
            //Console.WriteLine("-------------");
            //st.Print();
            //Console.WriteLine("-------------");
            //Console.WriteLine(st.GetTop());
            //Console.WriteLine(st.isEmpty());
            //Console.WriteLine("-------------");
            //Console.WriteLine(st.isFull());




            //StackLinkedList sts = new StackLinkedList();
            //sts.getMax();
            //Console.WriteLine("-------------");
            //sts.pop();
            //Console.WriteLine("-------------");
            //sts.push(1);
            //sts.push(2);
            //sts.push(3);
            //sts.push(4);
            //sts.push(5);
            //sts.push(6);
            //sts.display();
            //Console.WriteLine("-------------");
            //sts.sizeOfStack();
            //Console.WriteLine("-------------");
            //sts.pop();
            //sts.display();
            //Console.WriteLine("-------------");
            //sts.peekAndPop();
            //Console.WriteLine("-------------");
            //sts.peekAndPop();
            //Console.WriteLine("-------------");
            //sts.sizeOfStack();
            //Console.WriteLine("-------------");
            //sts.display();
            //Console.WriteLine("-------------");
            //sts.push(10);
            //sts.display();                                              //stack LinkedList
            //Console.WriteLine("-------------");
            //sts.sizeOfStack();
            //Console.WriteLine("-------------");
            //Console.WriteLine("-------------");
            //sts.getMax();
            //Console.WriteLine("-------------");
            //Console.WriteLine("-------------");
            //sts.getMin();
            //Console.WriteLine("-------------");
            //Console.WriteLine("-------------");
            //sts.Sum();
            //Console.WriteLine("-------------");
            //Console.WriteLine("-------------");
            //bool found = sts.search(110);
            //Console.WriteLine(found);
            //Console.WriteLine("-------------");
            //Console.WriteLine("-------------");



            //QueueuArray q = new QueueuArray(5);
            //q.Enqueue(5);
            //q.Enqueue(8);
            //q.Enqueue(3);
            //q.Enqueue(7);
            //q.getTop();
            //Console.WriteLine("------------");
            //q.display();                                         //queue array 
            //Console.WriteLine("------------");
            //q.Enqueue(20);
            //q.display();
            //q.dequeue();
            //q.dequeue();
            //q.display();
            //q.getTop();
            //q.dequeue();
            //q.dequeue();
            //q.display();
            //q.Enqueue(30);




            //CircularQueueArray c = new CircularQueueArray(5);
            //Console.WriteLine(c.isEmpty());
            //Console.WriteLine(c.isFull());
            //Console.WriteLine("------------");
            //c.enqueue(1);
            //c.enqueue(5);
            //c.enqueue(6);
            //c.enqueue(9);
            //c.enqueue(10);
            //c.display();
            //Console.WriteLine(c.isEmpty());                 //CircularQueueArray
            //Console.WriteLine(c.isFull());
            //Console.WriteLine("------------");
            //c.dequeue();
            //c.display();
            //Console.WriteLine("------------");
            //c.enqueue(0);
            //c.display();
            //Console.WriteLine(c.isFull());
            //c.enqueue(20);






            //QueueLinkedList q = new QueueLinkedList();
            //q.getSize();
            //Console.WriteLine(q.isEmpty());
            //q.dequeue();
            //Console.WriteLine("------------");
            //q.enqueue(1);
            //q.enqueue(2);
            //q.enqueue(56);
            //q.enqueue(70);
            //q.enqueue(3);
            //q.enqueue(40);
            //q.enqueue(4);
            //q.enqueue(5);
            //q.display();
            //Console.WriteLine("------------");
            //q.dequeue();                                              //QueueLinkedList
            //q.dequeue();
            //q.display();
            //Console.WriteLine("------------");
            //q.getTop();
            //Console.WriteLine("------------");
            //q.getMax();
            //Console.WriteLine("------------");
            //q.getMin();
            //Console.WriteLine("------------");
            //q.getSize();
            //Console.WriteLine("------------");
            //q.getSum();
            //Console.WriteLine("------------");
            //Console.WriteLine(q.search(7555));





            //LinkedList linkedList = new LinkedList();
            //Console.WriteLine(linkedList.getSize());
            //linkedList.insertFirst(4);
            //linkedList.insertFirst(3);
            //linkedList.insertFirst(2);
            //linkedList.insertFirst(1);
            //linkedList.insertLast(6);
            //linkedList.insertLast(7);
            //linkedList.insertLast(8);
            //linkedList.Display();
            //linkedList.search(8);
            //Console.WriteLine(linkedList.getSize());
            //linkedList.Display();                                   //linked list
            //Console.WriteLine(linkedList.getSize());
            //Console.WriteLine("---------------");
            //linkedList.deleteLast();
            //linkedList.deleteLast();
            //linkedList.Display();
            //linkedList.deletePos(2);
            //linkedList.Display();
            //linkedList.insertSorted(3);
            //linkedList.Display();
            //linkedList.insertSorted(0);
            //linkedList.Display();
            //linkedList.insertPos(5, 5);
            //linkedList.Display();
            LinkedList ll=new LinkedList();
            ll.insertFirst(4);
            ll.insertFirst(3);
            ll.insertFirst(2);
            ll.insertFirst(1);
            ll.insertLast(6);
            ll.insertLast(7);
            ll.insertLast(8);
            ll.Display();
            ll.insertSorted(8);
            ll.Display();
            ll.reverseList();
            ll.Display();
        }
    }
}
