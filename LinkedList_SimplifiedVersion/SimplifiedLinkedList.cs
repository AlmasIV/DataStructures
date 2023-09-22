namespace LinkedList_SimplifiedVersion;

public class SimplifiedLinkedList<T> {
    private Node? _head = null;
    private Node? _tail = null;
    public int Length { get; private set; } = 0;
    public void Append(T? item){
        Node oldTail = _tail!;
        _tail = new Node();
        _tail.Item = item;
        if(Length == 0){
            _head = _tail;
        }
        else{
            oldTail.Next = _tail;
        }
        Length ++;
    }
    public T? RemoveLast(){
        if(Length > 0){
            T? item = default(T);
            if(Length > 1){
                Node? tempNode = _head;
                while(tempNode!.Next != _tail){
                    tempNode = tempNode.Next;
                }
                item = _tail!.Item;
                tempNode.Next = null;
                _tail = tempNode;
            }
            else{
                item = _head!.Item;
                _head = _tail = null;
            }
            Length --;
            return item;
        }
        throw new InvalidOperationException("The linked-list is empty.");
    }
    private class Node {
        public T? Item { get; set; }
        public Node? Next { get; set; } = null;
    }
}