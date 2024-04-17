using Introduction;

namespace Introduction.Tasks;

/// <summary>
///     The class contains the methods that flattens the binary tree using depth first approach.
/// </summary>
public static class DepthFirstValues {

    /// <summary>
    ///     Flattens a binary tree starting from the root node, and returns the values in an array.
    /// </summary>
    /// <remarks>
    ///     Uses iterative approach.
    /// </remarks>
    /// <param name="rootNode">
    ///     The root node of a binary tree.
    /// </param>
    /// <returns>
    ///     The array of values of the flattened binary tree.
    /// </returns>
    public static List<T> FlattenIterative<T>(Node<T> rootNode){
        // Runtime O(N).

        if(rootNode is null){
            return new List<T>();
        }

        Stack<Node<T>> tempQueue = new Stack<Node<T>>();
        tempQueue.Push(rootNode);

        List<T> result = new List<T>();
        Node<T>? current;

        while(tempQueue.Count > 0){
            current = tempQueue.Pop();
            result.Add(current.Data);

            if(current.Right is not null){
                tempQueue.Push(current.Right);
            }

            if(current.Left is not null){
                tempQueue.Push(current.Left);
            }
        }
        return result;
    }

    /// <summary>
    ///     Flattens a binary tree starting from the root node, and returns the values in an array.
    /// </summary>
    /// <remarks>
    ///     Uses recursive approach.
    /// </remarks>
    /// <param name="rootNode">
    ///     The root node of a binary tree.
    /// </param>
    /// <returns>
    ///     The array of values of the flattened binary tree.
    /// </returns>
    public static List<T> FlattenRecursive<T>(Node<T> rootNode){
        if(rootNode is null){
            return new List<T>();
        }
        List<T> leftValues = FlattenRecursive(rootNode.Left!);
        List<T> rightValues = FlattenRecursive(rootNode.Right!);

        return leftValues.Concat(rightValues).Prepend(rootNode.Data).ToList();
    }
}