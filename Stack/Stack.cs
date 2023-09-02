using System.Collections;

namespace CustomStack;

public class Stack<T> : IStack<T>
{
    private List<T> stack = new List<T>();
    private int length { get; set; } = 0;
    public int Length {
        get {
            return length;
        }
    }

    public bool IsEmpty {
        get {
            return length == 0;
        }
    }

    public T Pop()
    {
        if(length > 0){
            length --;
            T poppedItem = stack[length];
            stack.RemoveAt(length);
            return poppedItem;
        }
        throw new IndexOutOfRangeException("The stack is empty.");
    }

    public void Push(T item)
    {
        stack.Add(item);
        length ++;
    }

    private class StackIterator : IEnumerator<T>
    {
        public T Current => throw new NotImplementedException();

        object IEnumerator.Current => throw new NotImplementedException();

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}