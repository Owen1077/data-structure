using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_Two_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new LinkedList<int>();

            var stack = new Stack<int>();

            var queue = new Queue<int>();

            list.Adding(1);
            list.Adding(2);
            list.Adding(3);
            list.Adding(4);
            
            stack.StackPush(6);
            stack.StackPush(7);
            stack.StackPush(8);
            stack.StackPush(9);

            queue.Enqueue(11);
            queue.Enqueue(12);
            queue.Enqueue(13);
            queue.Enqueue(14);
            
            Console.WriteLine(list.check(3));
            list.Print();
            Console.WriteLine("");
            Console.WriteLine(list.Index(3));
            list.Remove(2);
            Console.WriteLine("");
            list.Print();
            Console.WriteLine("");

            stack.PrintStack();           
            Console.WriteLine(stack.StackIsEmpty());
            stack.PeekStack();
            stack.PopStack();
            Console.WriteLine("");

            queue.PrintQueue();
            Console.WriteLine("");           
            queue.QueueSize();            
            queue.Dequeue();
            Console.WriteLine("");
            Console.WriteLine(queue.QueueIsEmpty());
           
           
        }
    }
}
