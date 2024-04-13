using System.Collections;

namespace Linked_Lists;

/// <summary>
///     Represents sorted doubly linked list, that internally uses doubly linked list.
/// </summary>
public class SortedDoublyLinkedList<T> : ILinkedList<T> where T : IComparable<T>
{
    ///     Gets the top cell (the first cell) of the doubly linked list. Or <c>null</c> if the doubly linked list is empty.
    /// </summary>
    private DoublyCell<T>? _top { get; set; }
    ///     Gets the bottom cell (the last added item) of the doubly linked list. Or <c>null</c> if the doubly linked list is empty.
    /// </summary>
    private DoublyCell<T>? _bottom { get; set; }

    /// <summary>
    ///     Gets the number of nodes that are contained in the sorted doubly linked list.
    /// </summary>
    public int Length { get; private set; } = 0;
    public void Add(T data)
    {
        // Runtime O(N).

        ArgumentNullException.ThrowIfNull(data);

        DoublyCell<T> newCell = new DoublyCell<T>(){
            Data = data
        };

        if(_top is null){
            _top = newCell;
            _bottom = _top;
        }
        else{
            DoublyCell<T>? temp = _top;
            while(temp is not null && temp.Data.CompareTo(data) != 1){
                temp = temp.Next;
            }
            if(temp is not null){
                if(temp != _top){
                    newCell.Previous = temp.Previous!;
                    temp.Previous!.Next = newCell;
                    temp.Previous = newCell;
                    newCell.Next = temp;
                }
                else{
                    newCell.Next = _top;
                    _top.Previous = newCell;
                    _top = newCell;
                }
            }
            else{
                _bottom!.Next = newCell;
                newCell.Previous = _bottom;

                _bottom = newCell;
            }
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

        if(Length == 0){
            throw new InvalidOperationException("The list is already empty.");
        }

        if(Length > 1){
            _bottom = _bottom!.Previous;
            _bottom!.Next = null;
            Length --;
        }
        else{
            Clear();
        }
    }

    public bool Exists(T value)
    {
        ArgumentNullException.ThrowIfNull(value);

        foreach(T t in this){
            if(t.Equals(value)){
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

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
