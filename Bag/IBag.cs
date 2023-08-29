namespace Bag;

///<summary>
///  Represent a generic bag interface.
///<summary>
///<typeparam name="T">
///  The type of items held in the bag.
///</typeparam>
public interface IBag<T>{
    ///<summary>
    ///  Adds an item to the bag.
    ///</summary>
    ///<param name="item">
    ///  The item to add.
    ///</param>
    public void Add(T item);

    ///<summary>
    ///  Checks if the bag is empty.
    ///</summary>
    ///<returns>
    ///  True if the bag is empty, otherwise false.
    ///</returns>
    public bool IsEmpty();

    ///<summary>
    ///  Gets the number of items in the bag.
    ///</summary>
    public int Length { get; private set; }
}