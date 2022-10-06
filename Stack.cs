using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_Two_Task
{
    public class Stack<T>
    {
        LinkedList<T> stackLink = new LinkedList<T>();

        public void StackPush(T data)
        {
            stackLink.Adding(data);
        }
        public T PopStack()
        {
            return stackLink.RemoveLast();
        }
        public T PeekStack()
        {
           return stackLink.ShowLast();
        }
        public void StackSize()
        {
           stackLink.count();
        }

        public bool StackIsEmpty()
        {
           return stackLink.IsEmpty();
        }
        public void PrintStack()
        {
            stackLink.Print();
        } 
    }
}
