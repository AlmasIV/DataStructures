namespace Introduction;

/// <summary>
///     Represents a node of type <typeparamref name="T" /> of a binary tree.
/// </summary>
/// <typeparam name="T">
///     The type of a node.
/// </typeparam>
public class Node<T> {
    /// <summary>
    ///     The data that a node holds.
    /// </summary>
    public T Data;

    /// <summary>
    ///     The left child of a node.
    /// </summary>
    public Node<T>? Left = null;

    /// <summary>
    ///     The right child of a node.
    /// </summary>
    public Node<T>? Right = null;
    public Node(T data){
        Data = data;
    }
}