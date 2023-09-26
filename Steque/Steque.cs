using System.Collections;

namespace Steque;

public class Steque<T> : ISteque<T>, IEnumerable<T>
{
    public int Length { get; private set; } = 0;

    private Node? _head = null;
    private Node? _tail = null;

    public bool IsEmpty {
        get {
            return Length == 0;
        }
    }

    public void Enqueue(T? item)
    {
        Node? oldTail = _tail;
        _tail = new Node(item);
        if(oldTail == null){
            Push(item);
        }
        else{
            oldTail.Next = _tail;
            Length ++;
        }
    }

    public T? Pop()
    {
        if(IsEmpty){
            throw new InvalidOperationException("The steque is empty.");
        }
        T? poppedItem = _head!.Data;
        _head = _head.Next;
        Length --;
        return poppedItem;
    }

    public void Push(T? item)
    {
        Node? oldHead = _head;
        _head = new Node(item);
        if(oldHead == null){
            _tail = _head;
        }
        else{
            _head.Next = oldHead;
        }
        Length ++;
    }

    public IEnumerator<T> GetEnumerator()
    {
        Node? tempNode = _head;
        while(tempNode != null){
            yield return tempNode!.Data!;
            tempNode = tempNode.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    ///<summary>
    ///  Represents a node of a linked-list.
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