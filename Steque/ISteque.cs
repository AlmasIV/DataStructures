namespace Steque;

///<summary>
///  Represent the generic steque interface.
///</summary>
///<typeparam name="T">
///  The type of the items held in the steque.
///</typeparam>
public interface ISteque<T>{
    ///<summary>
    ///  Gets the number of items in the steque.
    ///</summary>
    public int Length { get; }

    ///<summary>
    ///  Checks if the steque is empty.
    ///</summary>
    public bool IsEmpty { get; }

    ///<summary>
    ///  Adds an item to the end of the steque.
    ///</summary>
    ///<param name="item">
    ///  The item to be added to the end of the steque.
    ///</param>
    public void Enqueue(T? item);

    ///<summary>
    ///  Pushes an item to the begining of the steque.
    ///</summary>
    ///<param name="item">
    ///  The item to be pushed to the begining of the steque.
    ///</param>
    public void Push(T? item);

    ///<summary>
    ///  Pops an item from the begining of the steque.
    ///</summary>
    ///<returns>
    ///  The popped item.
    ///</returns>
    ///<exception cref="InvalidOperationException">
    ///  Thrown when the steque is empty.
    ///</exception>
    public T? Pop();
}