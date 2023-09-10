namespace LinkedListStack;

class Program
{
    static void Main(string[] args)
    {
        Stack<int> myStack = new Stack<int>();
        myStack.Push(121);
        myStack.Push(202);
        foreach(var v in myStack){
            Console.WriteLine(v);
        }
    }
}
