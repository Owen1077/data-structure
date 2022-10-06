using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Week_Two_Task
{
    public class Node<T>
    {
       public T Data;
       public Node<T> Next;

        public Node (T data)
        {
          this.Data = data;
            this.Next = null;
        }
    }
    public class LinkedList<T>
    {
        Node<T> previous;
        
        Node<T> head;
        
        Node<T> current;

        Node<T> tail;
       
        public void Adding (T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (head == null)
            {
                head = newNode;
                return;
            }
            Node<T> current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
        public bool Remove(T item)
        {

            current = head;
            previous = null;
            while(current != null && !current.Data.Equals(item))
            {
                previous = current;
                current = current.Next;
            } if(current != null && current.Data.Equals(item))
            {if(previous != null)
                {
                    previous.Next = current.Next;
                    if(current.Next == null)
                    {
                        tail = previous;
                    }
                } else
                {
                    Console.WriteLine("END");
                }
                return true;
            } return false;

        }

        public bool check(T item)
        {
           
            current = head;
            

            while (current != null && !current.Data.Equals(item))
            {
                current = current.Next;
            }
            if (current != null && current.Data.Equals(item))
            {
                return true;
            }
            else return false;
        }

   
        public int Index(T data)
        {
            int index = 0;
            current = head;
            while (current !=null && !current.Data.Equals(data))
            {
                current=current.Next;
                index++;
            } if(current == null)
            {
                return - 1;
            }return index;
        }
        public T ShowLast()
        {
             current = head;

                    while (current.Next != tail)
                    {
                        current = current.Next;
                    }
                    current.Next = null;
                    tail = current;
            Console.WriteLine(current.Data);
            return current.Data;
            }

       
        public T RemoveLast()
        {
            current = head;

                 while (current.Next != tail)
                    {
                        current = current.Next;
                    }
                    current.Next = null;
                    tail = current;

            Console.WriteLine(tail.Data);
            return tail.Data;
                }
         

        public void count()
        {
            int count = 0;
            if (head == null)
            {
                Console.WriteLine("This stack is empty");
            }
            current = null;
            current = head;
            while (current != null)
            {
                count++;
                current = current.Next;
            }
            Console.WriteLine(count);
        }

        public bool IsEmpty()
        {
            if (head == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
       
        public void Print()
        {
            Node<T> current = head;
            while (current != null)
            {
                Console.WriteLine(current.Data );
                current = current.Next;
            } 
        }

    }
    
}
