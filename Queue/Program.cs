namespace CustomQueue;

class Program
{
    static void Main(string[] args)
    {
        Queue<int> myNums = new Queue<int>();
        myNums.Enqueue(190);
        myNums.Enqueue(200);
        myNums.Enqueue(99);
        foreach(int num in myNums){
            Console.WriteLine(num);
        }

        Console.WriteLine("Removing: " + myNums.Dequeue());

        foreach(int num in myNums){
            Console.WriteLine(num);
        }
    }
}
