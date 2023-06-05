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

        //UC2-Add last method in linked list
        public void AddLast(Node<T> newNode)
        {
            if (head == null)
            {
                head = newNode;
                return;
            }
            Node<T> temp = head;

            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newNode;
        }

        //UC3-Add after method in linked list
        public void AddAfter(Node<T> data, Node<T> newNode)
        {
            Node<T> temp = data;
            while (temp.Next == null)
            {
                temp.Next = newNode;
                return;
            }
            newNode.Next = temp.Next;
            temp.Next = newNode;
        }

        //UC4-Delete first method in linked list
        public void DeleteFirst()
        {
            if (head == null)
                return;
            
            Node<T> temp = head.Next;
            head = temp;
        }

        //UC5-Delete last method in linked list
        public void DeleteLast()
        {
            Node<T> temp = head;
            while (temp.Next.Next != null)
            {
                temp = temp.Next;
            }

            temp.Next = null;
        }

        //UC6-Delete after method in linked list
        public void DeleteAfter(Node<T> node)
        {
            Node<T> temp = node.Next;
            node.Next = temp.Next;
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
