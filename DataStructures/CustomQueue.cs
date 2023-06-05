using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class CustomQueue<T>
    {
        private CustomLinkedList<T> linkedList = new CustomLinkedList<T>();

        //UC9-Enqueue method
        public void Enqueue(T data)
        {
            Node<T> newNode = new Node<T>(data);
            linkedList.AddLast(newNode);
        }

        //UC9-Dequeue method
        public void Dequeue()
        {
            linkedList.DeleteFirst();
        }

        public void Print()
        {
            linkedList.Display();
        }
    }
}
