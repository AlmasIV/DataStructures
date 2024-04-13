using System.Collections;

namespace Linked_Lists;

/// <summary>
///     Represents the doubly linked list of the specified type.
/// </summary>
/// <remarks>
///     A doubly linked list is one in which each cell is connected to the following cell, and to the previous cell.
/// </remarks>
/// <typeparam name="T">
///     The type that is being stored.
/// </typeparam>
public class DoublyLinkedList<T> : ILinkedList<T>
{
    private DoublyCell<T>? _top { get; set; } = null;
    private DoublyCell<T>? _bottom { get; set; } = null;

    /// <summary>
    ///     Gets the number of cells (<c>Cell</c>) that are contained in the doubly linked list.
    /// </summary>
    public int Length { get; private set; } = 0;

    public void Add(T data)
    {
        // Runtime O(1).

        ArgumentNullException.ThrowIfNull(data);

        DoublyCell<T> cell = new DoublyCell<T>(){
            Data = data
        };

        if(_top is null){
            _top = cell;
            _bottom = _top;
        }
        else{
            _bottom!.Next = cell;
            cell.Previous = _bottom;
            _bottom = cell;
        }

        Length ++;
    }

    public void Clear()
    {
        // Runtime O(1).

        _top = null;
        _bottom = null;

        Length = 0;
    }

    public void DeleteLast()
    {
        // Runtime O(1).

        if(_top is null){
            throw new InvalidOperationException("The doubly linked list is empty.");
        }

        if(_bottom == _top){
            Clear();
        }
        else{
            _bottom = _bottom!.Previous;
            _bottom!.Next = null;
            Length --;
        }
    }

    public bool Exists(T value){
        // Runtime O(N).

        ArgumentNullException.ThrowIfNull(value);

        foreach(T data in this){
            if(data!.Equals(value)){
                return true;
            }
        }

        return false;
    }

    public IEnumerator<T> GetEnumerator()
    {
        // Runtime O(N).

        DoublyCell<T>? temp = _top;

        while(temp is not null){
            yield return temp.Data;
            temp = temp.Next;
        }
    }

    /// <summary>
    ///     Prepends a new node that holds the value of <paramref name="data" /> to the beginning of the linked list.
    /// </summary>
    /// <param name="data">
    ///     The value that a new node will hold.
    /// </param>
    /// <exception cref="System.ArgumentNullException">
    ///     Thrown if the <paramref name="data" /> is <c>null</c>.
    /// </exception>
    public void Prepend(T data)
    {
        // Runtime O(1).

        ArgumentNullException.ThrowIfNull(data);

        if(_top is null){
            Add(data);
        }
        else{
            DoublyCell<T> newCell = new DoublyCell<T>(){
                Data = data
            };
            newCell.Next = _top;
            _top.Previous = newCell;

            _top = newCell;
            Length ++;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}