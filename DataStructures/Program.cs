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
            list.AddLast(secondNode);
            list.AddLast(fifthNode);

            list.Display();
        }
    }
}