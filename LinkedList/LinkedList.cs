namespace LinkedList;
public class LinkedList<T>
{
    private Node? _head { get; set; }
    private Node? _tail { get; set; }
    public int Length { get; private set; } = 0;
    public void Add(T data){
        if(_head == null){
            _head = new Node(data);
            _tail = _head;
        }
        else{
            _tail!.Next = new Node(data);
            _tail = _tail.Next;
        }
        Length ++;
    }
    public void Insert(int position, T data){
        if(position <= Length){
            if(position == Length){
                this.Add(data);
            }
            else{
                Node temp = _head!;
                // Hello world!
                return;
               // while(position < Length)
            }
        }
        else{
            throw new ArgumentOutOfRangeException("The position is greater than the Length of the linked list.");
        }
    }
    public void ListItems(){
        Node? temp = _head;
        while(temp != null){
            Console.WriteLine(temp.Data);
            temp = temp.Next;
        }
    }
    private class Node 
    {
        public T? Data { get; set; }
        public Node? Next { get; set; }
        public Node(T data){
            Data = data;
            Next = default;
        }
    }
}