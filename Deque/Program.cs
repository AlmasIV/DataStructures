namespace Deque;

class Program
{
    static void Main(string[] args)
    {
        Deque<int> deq = new Deque<int>();
        deq.PushLeft(99);
        deq.PushRight(100);
        deq.PushRight(88);
        deq.PopLeft();
        foreach(var v in deq){
            Console.WriteLine(v);
        }
    }
}
