namespace CustomQueue;

///<summary>
///  Represents a generic queue interface.
///</summary>
///<typeparam name="T">
///  The type of items held in the key.
///</typeparam>
public interface IQueue<T>{
    ///<summary>
    ///  Gets the number of items in the queue.
    ///</summary>
    public int Length { get; }
    
    ///<summary>
    ///  Adds an item to the end of the queue.
    ///</summary>
    ///<param name="item">
    ///  The item to enqueue.
    ///</param>
    public void Enqueue(T item);

    ///<summary>
    ///  Removes an item from the front of the queue.
    ///</summary>
    ///<returns>
    ///  The item removed from the front of the queue.
    ///</returns>
    public T Dequeue();

    ///<summary>
    ///  Checks if the queue is empty.
    ///</summary>
    ///<returns>
    ///  True if the queue is empty, otherwise false.
    ///</returns>
    public bool IsEmpty();
}