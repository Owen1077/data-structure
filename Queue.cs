using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_Two_Task
{
    public class Queue<T>
    {
        LinkedList<T> QueueLink = new LinkedList<T>();
        public bool QueueIsEmpty()
        {
            return QueueLink.IsEmpty();
        }
        public void Enqueue(T data)
        {
            QueueLink.Adding(data);
        }
        public T Dequeue()
        {
            return QueueLink.RemoveLast();
        }
        public void QueueSize()
        {
            QueueLink.count();
        }
        public void PrintQueue()
        {
            QueueLink.Print();
        }
    }
}
