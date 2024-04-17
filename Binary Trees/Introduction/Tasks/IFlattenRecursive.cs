namespace Introduction.Tasks;

/// <summary>
///     Enables flattenning a binary tree. Assumes that a developer implements a recursive approach.
/// </summary>
public interface IFlattenRecursive {
    /// <summary>
    ///     Flattens a binary tree starting from the root node, and returns the values in a list.
    /// </summary>
    /// <remarks>
    ///     Uses recursive approach.
    /// </remarks>
    /// <param name="rootNode">
    ///     The root node of a binary tree.
    /// </param>
    /// <returns>
    ///     The list of values of the flattened binary tree.
    /// </returns>
    public List<T> FlattenRecursive<T>(Node<T> rootNode);
}