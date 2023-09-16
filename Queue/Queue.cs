using System.Collections;
using DoublyLinkedList;
namespace CustomQueue;

public class Queue<T> : IQueue<T>, IEnumerable<T>
{
    private DoublyLinkedList<T> queue = new DoublyLinkedList<T>();
    public int Length { get; }
    public void Enqueue(T item){
        queue.Add(item);
    }
    public T Dequeue(){
        return queue.Shift()!;
    }
    public bool IsEmpty(){
        return Length == 0;
    }

    public IEnumerator<T> GetEnumerator()
    {
        return queue.Enumerate();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}