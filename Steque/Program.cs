namespace Steque;

class Program
{
    static void Main(string[] args)
    {
        Steque<int> my = new Steque<int>();
        my.Push(121);
        my.Push(202);
        my.Enqueue(300);
        foreach(var v in my){
            Console.WriteLine(v);
        }
    }
}
