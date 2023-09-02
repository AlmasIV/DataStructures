using System.Collections;

namespace CustomStack;

public class Stack<T> : IStack<T>, IEnumerable<T>
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
     public IEnumerator<T> GetEnumerator()
    {
        return new StackIterator(stack);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    private class StackIterator : IEnumerator<T>
    {
        private List<T> _stack;
        private int currIndex;
        public T Current => _stack[currIndex];

        object IEnumerator.Current => Current!;
        public StackIterator(List<T> items){
            _stack = items;
            currIndex = items.Count;
        }

        public void Dispose()
        {}

        public bool MoveNext()
        {
            currIndex --;
            return currIndex >= 0;
        }

        public void Reset()
        {
            currIndex = _stack.Count;
        }
    }
}