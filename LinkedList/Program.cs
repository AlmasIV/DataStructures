namespace LinkedList;

class Program{
    static void Main(){
        LinkedList<int> lin = new LinkedList<int>();
        lin.Add(2);
        lin.Add(1);
        lin.Insert(2, -29);
        lin.Add(99);
        lin.DeleteNodeAt(3);
        lin.ListItems();
        Console.WriteLine("The length is: " + lin.Length);
    }
}