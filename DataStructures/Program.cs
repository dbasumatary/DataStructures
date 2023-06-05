using System.Collections;

namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data structures implementation\n");
            CustomLinkedList<int> list = new CustomLinkedList<int>();
            Node<int> firstNode = new Node<int>(23);
            Node<int> secondNode = new Node<int>(34);
            Node<int> thirdNode = new Node<int>(29);
            Node<int> fourthNode = new Node<int>(15);
            Node<int> fifthNode = new Node<int>(42);

            list.AddLast(thirdNode);
            list.AddLast(fourthNode);
            list.AddLast(firstNode);
            list.AddLast(fifthNode);

            list.AddAfter(fourthNode, secondNode);
            list.Display();

            list.DeleteFirst();
            list.Display();

            list.DeleteLast();
            list.Display();

            list.DeleteAfter(secondNode);
            list.Display();

            CustomStack<int> stackList = new CustomStack<int>();
            stackList.Push(21);
            stackList.Push(45);
            stackList.Push(37);
            stackList.Push(19);
            stackList.Push(56);

            stackList.Print();

        }
    }
}