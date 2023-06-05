using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class CustomStack<T>
    {
        private CustomLinkedList<T> linkedList = new CustomLinkedList<T>();

        //UC7-Stack push method
        public void Push(T data)
        {
            Node<T> newNode = new Node<T>(data);
            linkedList.AddLast(newNode);
        }

        //UC8-Stack pop method
        public void Pop()
        {
            linkedList.DeleteLast();
        }

        public void Print()
        {
            linkedList.Display();
        } 
    }
}
