namespace Linked_Lists;

/// <summary>
///     Represents the <c>DoublyCell</c> that stores the link to the next <c>DoublyCell</c>, to the previous <c>DoublyCell</c>, and the <typeparamref name="T" /> data.
/// </summary>
/// <typeparam>
///     The item that is being stored in the <c>DoublyCell</c>.
/// </typeparam>
public class DoublyCell<T> {

    /// <summary>
    ///     Gets or sets the pointer to the next <c>DoublyCell</c>.
    /// </summary>
    public DoublyCell<T>? Next { get; set; }

    /// <summary>
    ///     Gets or sets the pointer to the previous <c>DoublyCell</c>.
    /// </summary>
    public DoublyCell<T>? Previous { get; set; }

    /// <summary>
    ///     Gets or sets the data that is being stored.
    /// </summary>
    public T Data { get; set; } = default(T)!;
}