namespace DoublyLinkedList;

public class DoublyLinkedList<T> {
    private Node? _head { get; set; }
    private Node? _tail { get; set; }
    public int Length { get; private set; } = 0;
    public void Add(T data){
        if(_head == null){
            _head = new Node(data);
            _tail = _head;
        }
        else {
            _tail!.Next = new Node(data);
            _tail.Next.Previous = _tail;
            _tail = _tail.Next;
        }
        Length ++;
    }
    public void ListAll(){
        Node? tempNode = _head;
        while(tempNode != null){
            Console.WriteLine(tempNode.Data);
            tempNode = tempNode.Next;
        }
    }
    public void ReverseList(){
        Node? tempNode = _tail;
        while(tempNode != null){
            Console.WriteLine(tempNode.Data);
            tempNode = tempNode.Previous;
        }
    }
    private class Node {
        public T? Data { get; set; }
        public Node? Next { get; set; }
        public Node? Previous { get; set; }
        private Node(){}
        public Node(T? data){
            Data = data;
            Next = default;
            Previous = default;
        }
    }
}