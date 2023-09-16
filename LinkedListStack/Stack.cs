using DoublyLinkedList;
using CustomStack;
using System.Collections;

namespace LinkedListStack;

public class Stack<T> : IStack<T>, IEnumerable<T>
{
    private DoublyLinkedList<T> storage = new DoublyLinkedList<T>();
    public bool IsEmpty {
        get {
            return Length == 0; 
        }
    }

    public int Length {
        get {
            return storage.Length;
        }
    }

    public IEnumerator<T> GetEnumerator()
    {
        return storage.EnumerateReversed();
    }

    public T? Pop()
    {
        if(!IsEmpty){
            T? poppedData = storage.Pop();
            return poppedData;
        }
        throw new NullReferenceException("The Stack is empty.");
    }

    public void Push(T item)
    {
        storage.Add(item);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}