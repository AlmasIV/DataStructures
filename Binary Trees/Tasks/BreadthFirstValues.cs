namespace BinaryTrees.Tasks;

/// <summary>
///     The class contains the methods that flattens the binary tree using breadth first approach.
/// </summary>
public class BreadthFirstValues : IFlattenIterative
{
    public List<T> FlattenIterative<T>(Node<T> rootNode)
    {
        // Runtime O(N).
        if(rootNode is null){
            return new List<T>();
        }

        Queue<Node<T>> queue = new Queue<Node<T>>();
        queue.Enqueue(rootNode);
        Node<T>? temp;

        List<T> result = new List<T>();

        while(queue.Count > 0){
            temp = queue.Dequeue();
            result.Add(temp.Data);

            if(temp.Left is not null){
                queue.Enqueue(temp.Left);
            }

            if(temp.Right is not null){
                queue.Enqueue(temp.Right);
            }
        }

        return result;
    }
}