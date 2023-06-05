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

            list.AddFirst(firstNode);
            list.AddFirst(secondNode);
            list.AddFirst(thirdNode);
            list.AddFirst(fourthNode);
            list.AddFirst(fifthNode);

            list.Display();
        }
    }
}