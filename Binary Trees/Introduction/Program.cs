using Introduction.Tasks;

namespace Introduction;

class Program
{
    static void Main()
    {
        var a = new Node<char>('a');
        var b = new Node<char>('b');
        var c = new Node<char>('c');
        var d = new Node<char>('d');
        var e = new Node<char>('e');
        var f = new Node<char>('f');
        var g = new Node<char>('g');

        a.Left = b;
        a.Right = c;
        b.Left = d;
        b.Right = e;
        c.Right = f;
        f.Right = g;

        Console.WriteLine("Iterative approach: ");
        foreach(char ch in (new DepthFirstValues()).FlattenIterative(a)){
            Console.WriteLine(ch);
        }
        Console.WriteLine("Recursive approach: ");
        foreach(char ch in (new DepthFirstValues()).FlattenRecursive(a)){
            Console.WriteLine(ch);
        }
    }
}
