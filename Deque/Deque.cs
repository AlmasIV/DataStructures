using System.Collections;

namespace Deque;

///<summary>
///  Represents the deque data structure.
///</summary>
public class Deque<T> : IDeque<T>, IEnumerable<T?>
{
    Node? _head = null;
    Node? _tail = null;
    public bool IsEmpty {
        get {
            return Length == 0;
        }
    }

    public int Length { get; private set; } = 0;

    public IEnumerator<T?> GetEnumerator()
    {
        Node? temp = _head;
        while(temp != null){
            yield return temp.Data;
            temp = temp.Next;
        }
    }

    public T? PopLeft()
    {
        if(IsEmpty){
            throw new InvalidOperationException("The deque is empty.");
        }
        Node leftMost = _head!;
        _head = _head!.Next;
        _head!.Previous = null;
        Length --;
        return leftMost.Data;
    }

    public T? PopRight()
    {
        if(IsEmpty){
            throw new InvalidOperationException("The deque is empty.");
        }
        Node rightMost = _tail!;
        _tail = _tail!.Previous;
        _tail!.Next = null;
        Length --;
        return rightMost.Data;
    }

    public void PushLeft(T? item)
    {
        Node? prevHead = _head;
        _head = new Node(item);
        if(prevHead == null){
            _tail = _head;
        }
        else{
            prevHead.Previous = _head;
            _head.Next = prevHead;
        }
        Length ++;
    }

    public void PushRight(T? item)
    {
        Node? prevTail = _tail;
        _tail = new Node(item);
        if(_tail == null){
            _head = _tail;
        }
        else{
            prevTail!.Next = _tail;
            _tail.Previous = prevTail;
        }
        Length ++;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    ///<summary>
    ///  Represents a node of a doubly linked-list.
    ///</summary>
    private class Node{
        ///<summary>
        ///  The data that the node helds.
        ///</summary>
        public T? Data;

        ///<summary>
        ///  The reference to the next node.
        ///</summary>
        public Node? Next;

        ///<summary>
        ///  The reference to the previous node.
        ///</summary>
        public Node? Previous;

        ///<summary>
        ///  Initializes a new node with the given data.
        ///</summary>
        ///<param name="data">
        ///  The data that the node helds.
        ///</param>
        public Node(T? data){
            Data = data;
        }
    }
}