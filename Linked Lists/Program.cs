namespace Linked_Lists;

class Program
{
    static void Main(string[] args)
    {
        SortedDoublyLinkedList<int> l = new SortedDoublyLinkedList<int>();

        l.Add(-2);
        l.Add(12);
        l.Add(22);
        l.Add(14);
        l.Add(-99);
        l.Add(15);
        l.Add(293);
        l.Add(0);

        ConsolePrint<int>(l);
    }
    static void ConsolePrint<T>(ILinkedList<T> linkedList){
        Console.WriteLine();
        foreach(T t in linkedList){
            Console.WriteLine(t);
        }
    }
}
