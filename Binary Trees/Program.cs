using BinaryTrees.Tasks;

namespace BinaryTrees;

class Program
{
    static void Main()
    {
        Node<char> a = _InitializeBinaryTree();

        Console.WriteLine("*** Depth First Values ***");
        DepthFirstValues dfv = new DepthFirstValues();
        Console.WriteLine("Iterative approach:");
        _OutputValues(dfv.FlattenIterative(a));
        Console.WriteLine("Recursive approach:");
        _OutputValues(dfv.FlattenRecursive(a));

        Console.WriteLine("\n*** Breadth First Values ***");
        BreadthFirstValues bfv = new BreadthFirstValues();
        Console.WriteLine("Iterative approach:");
        _OutputValues(bfv.FlattenIterative(a));
    }
    private static Node<char> _InitializeBinaryTree(){
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

        return a;
    }

    private static void _OutputValues(List<char> values){
        Console.WriteLine(string.Join(", ", values));
    }
}
