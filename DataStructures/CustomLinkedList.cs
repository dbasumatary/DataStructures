using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataStructures
{
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }

        public Node(T data)
        {
            this.Data = data;
        }
    }
    public class CustomLinkedList<T>
    {
        private Node<T> head;

        //UC1-Add first method in linked list
        public void AddFirst(Node<T> newNode)
        {
            if (head == null)
            {
                head = newNode;
                return;
            }

            Node<T> previous = head;
            head = newNode;
            newNode.Next = previous;
        }

        public void Display()
        {
            Node<T> temp = head;
            while (temp != null)
            {
                Console.Write(temp.Data + "->");
                temp = temp.Next;
            }
            Console.WriteLine("END");
        }
    }
}
