namespace Deque;

///<summary>
///  Represents the generic deque interface.
///<summary>
///<typeparam name="T">
///  The type of items held in the deque.
///</typeparam>
public interface IDeque<T>{

    ///<summary>
    ///  Checks if the deque is empty.
    ///</summary>
    public bool IsEmpty { get; }

    ///<summary>
    ///  Gets the number of items in the deque.
    ///</summary>
    public int Length { get; }

    ///<summary>
    ///  Adds the item to the left side of the deque.
    ///</summary>
    ///<param name="item">
    ///  The item that is added to the deque.
    ///</param>
    public void PushLeft(T? item);

    ///<summary>
    ///  Adds the item to the right side of the deque.
    ///</summary>
    ///<param name="item">
    ///  The item that is added to the deque.
    ///</param>
    public void PushRight(T? item);

    ///<summary>
    ///  Pops the rightmost item from the deque.
    ///</summary>
    ///<returns>
    ///  The item that is popped.
    ///</returns>
    ///<exception cref="InvalidOperationException">
    ///  Thrown if the deque is empty.
    ///</exception>
    public T? PopRight();

    ///<summary>
    ///  Pops the leftmost item from the deque.
    ///</summary>
    ///<returns>
    ///  The item that is popped.
    ///</returns>
    ///<exception cref="InvalidOperationException">
    ///  Thrown if the deque is empty.
    ///</exception>
    public T? PopLeft();
}