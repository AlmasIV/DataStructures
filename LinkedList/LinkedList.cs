
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
    public void DeleteNodeAt(int position){
        if(position < Length){
            if(position == 0){
                _head = _head!.Next;
            }
            else{
                Node prevNode = _GetNodeAt(position - 1)!;
                prevNode.Next = prevNode.Next!.Next;
            }
            Length --;
        }
        else {
            throw new ArgumentOutOfRangeException("position");
        }
    }
    private Node? _GetNodeAt(int position){
        if(position < Length){
            int tempPos = 0;
            Node? result = _head;
            while(tempPos < Length){
                if(tempPos == position){
                    break;
                }
                result = result!.Next;
                tempPos ++;
            }
            return result;
        }
        else {
            throw new ArgumentOutOfRangeException("position");
        }
    }
    public void Insert(int position, T data){
        if(position <= Length){
            if(position == Length){
                this.Add(data);
            }
            else{
                Node nextNode = _GetNodeAt(position)!;
                if(position == 0){
                    _head = new Node(data);
                    _head.Next = nextNode;
                }
                else {
                    Node prevNode = _GetNodeAt(position - 1)!;
                    prevNode.Next = new Node(data);
                    prevNode.Next.Next = nextNode;
                }
                Length++;
            }
        }
    }

    // For debugging output, I will delete it after I check everything.
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
