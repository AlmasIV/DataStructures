namespace DoublyLinkedList;

class Program
{
    static void Main(string[] args)
    {
        DoublyLinkedList<int> myLinkedList = new DoublyLinkedList<int>();
        myLinkedList.Add(89);
        myLinkedList.Add(100);
        myLinkedList.ListAll();
        Console.WriteLine("***REVERSING***");
        myLinkedList.ReverseList();
    }
}
