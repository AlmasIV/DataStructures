namespace Introduction.Tasks;

/// <summary>
///     Enables flattenning a binary tree. Assumes that a developer implements an iterative approach.
/// </summary>
public interface IFlattenIterative {
    /// <summary>
    ///     Flattens a binary tree starting from the root node, and returns the values in a list.
    /// </summary>
    /// <remarks>
    ///     Uses iterative approach.
    /// </remarks>
    /// <param name="rootNode">
    ///     The root node of a binary tree.
    /// </param>
    /// <returns>
    ///     The list of values of the flattened binary tree.
    /// </returns>
    public List<T> FlattenIterative<T>(Node<T> rootNode){
        throw new NotImplementedException();
    }
}