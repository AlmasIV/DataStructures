using System.Collections;

namespace Linked_Lists;

/// <summary>
///     Represents the singly linked list of the specified type.
/// </summary>
/// <remarks>
///     A singly linked list is one in which each cell is connected to the following cell by a reference.
/// </remarks>
/// <typeparam name="T">
///     The type that is being stored.
/// </typeparam>
public class SinglyLinkedList<T> : ILinkedList<T>
{
    private Cell<T>? _top { get; set; } = null;
    private Cell<T>? _bottom { get; set; } = null;
    
    /// <summary>
    ///     Gets the number of cells (<c>Cell</c>) that are contained in the singly linked list.
    /// </summary>
    public int Length { get; private set; } = 0;
    public void Add(T data){
        // Runtime O(1).

        ArgumentNullException.ThrowIfNull(data);

        Cell<T> newCell = new Cell<T>(){
            Data = data
        };

        if(_top is null){
            _top = newCell;
            _bottom = _top;
        }
        else{
            _bottom!.Next = newCell;
            _bottom = newCell;
        }

        Length ++;
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

    /// <summary>
    ///     Prepends a new node that holds the value of <paramref name="data" /> to the beginning of the linked list.
    /// </summary>
    /// <param name="data">
    ///     The value that a new node will hold.
    /// </param>
    /// <exception cref="System.ArgumentNullException">
    ///     Thrown if the <paramref name="data" /> is <c>null</c>.
    /// </exception>
    public void Prepend(T data){
        // Runtime O(1).

        ArgumentNullException.ThrowIfNull(data);

        if(_top is null){
            Add(data);
        }
        else{
            Cell<T> newCell = new Cell<T>(){
                Data = data
            };

            newCell.Next = _top;
            _top = newCell;
            
            Length ++;
        }
    }

    public void DeleteLast(){
        // Runtime O(N).

        if(_top is null){
            throw new InvalidOperationException("The singly linked list is empty.");
        }

        if(_bottom == _top){
            Clear();
        }
        else{
            Cell<T>? temp = _top;
            while(temp is not null){
                if(temp.Next == _bottom){
                    _bottom = temp;
                    _bottom.Next = null;
                    break;
                }

                temp = temp.Next;
            }
            Length --;
        }
    }

    public void Clear(){
        // Runtime O(1).

        _top = null;
        _bottom = null;

        Length = 0;
    }

    public IEnumerator<T> GetEnumerator()
    {
        // Runtime O(N).

        Cell<T>? temp = _top;

        while(temp is not null){
            yield return temp.Data;
            temp = temp.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}