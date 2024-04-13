namespace Linked_Lists;

/// <summary>
///     Represents the <c>Cell</c> that stores the link to the next <c>Cell</c> and the <typeparamref name="T" /> data.
/// </summary>
/// <typeparam>
///     The item that is being stored in the <c>Cell</c>.
/// </typeparam>
public class Cell<T> {

    /// <summary>
    ///     Gets or sets the data that is being stored.
    /// </summary>
    public T Data { get; set; } = default(T)!;

    /// <summary>
    ///     Gets or sets the pointer to the next <c>Cell</c>.
    /// </summary>
    public Cell<T>? Next { get; set; }
}