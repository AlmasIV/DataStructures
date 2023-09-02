namespace CustomStack;

class Program
{
    static void Main(string[] args)
    {
        Stack<int> intStack = new Stack<int>();
        intStack.Push(199);
        intStack.Push(201);
        intStack.Push(909);
        foreach(var v in intStack){
            Console.WriteLine(v);
        }
        intStack.Pop();
        foreach(var v in intStack){
            Console.WriteLine(v);
        }
    }
}
