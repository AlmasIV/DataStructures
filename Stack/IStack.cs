namespace Stack;

///<summary>
///  Represents a generic stack interface.
///</summary>
///<typeparam name="T">
///  The type of items held in the stack.
///</typeparam>
public interface IStack<T> {
    ///<summary>
    ///  Adds an item to the stack.
    ///</summary>
    ///<param name="item">
    ///  The item to be pushed.
    ///</param>
    public void Push(T item);

    ///<summary>
    ///  Removes the last item from the stack.
    ///</summary>
    ///<returns>
    ///  The popped item.
    ///</returns>
    public T Pop();

    ///<summary>
    ///  Checks if the stack is empty.
    ///</summary>
    ///<returns>
    ///  True if the stack is empty, otherwise false.
    ///</returns>
    public bool IsEmpty();

    ///<summary>
    ///  Gets the number of items in the stack.
    ///</summary>
    public int Length { get; private set; }
}