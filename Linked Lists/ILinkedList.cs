namespace Linked_Lists;

/// <summary>
///     Defines the contract for linked lists.
/// </summary>
/// <typeparam name="T">
///     The type that the linked list operates on.
/// </typeparam>
public interface ILinkedList<T> : IEnumerable<T> {
    /// <summary>
    ///     Adds a new node that holds the value of <paramref name="data" /> to the end of the linked list.
    /// </summary>
    /// <param name="data">
    ///     The value that a new node will hold.
    /// </param>
    /// <exception cref="System.ArgumentNullException">
    ///     Thrown if the <paramref name="data" /> is <c>null</c>.
    /// </exception>
    public void Add(T data);

    /// <summary>
    ///     Checks whether the node that holds the same value as the <paramref name="value" /> exists in the linked list.
    /// </summary>
    /// <returns>
    ///     Returns <c>true</c> if the <paramref name="value" /> exists in the linked list, otherwise <c>false</c> will be returned.
    /// </returns>
    /// <param name="value">
    ///     The value that is being that a possible node holds.
    /// </param>
    /// <exception cref="System.ArgumentNullException">
    ///     Thrown if the <paramref name="value" /> is <c>null</c>.
    /// </exception>
    public bool Exists(T value);

    /// <summary>
    ///     Deletes the last element from the linked list.
    /// </summary>
    /// <exception cref="System.InvalidOperationException">
    ///     Thrown if the linked list is empty.
    /// </exception>
    public void DeleteLast();

    /// <summary>
    ///     Cleares the linked list.
    /// </summary>
    public void Clear();
}