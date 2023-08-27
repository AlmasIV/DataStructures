namespace LinkedList;
///<summary>
///  Linked list data type.
///</summary>
///<typeparam name="T">
///  The type of elements in the linked list.
///</typeparam>
public class LinkedList<T>
{
    ///<summary>
    ///  Gets or sets the head node of the linked list.
    ///</summary>
    private Node? _head { get; set; }

    ///<summary>
    ///  Gets or sets the tail node of the linked list.
    ///</summary>
    private Node? _tail { get; set; }

    ///<summary>
    ///  Gets the length of the linked list.
    ///</summary>
    public int Length { get; private set; } = 0;

    ///<summary>
    ///  Adds a new node to the end of the linked list.
    ///</summary>
    ///<param name="name">
    ///  The data of the node.
    ///</param>
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

    ///<summary>
    ///  Deletes the node at the specified position in the linked list.
    ///</summary>
    ///<param name="position">
    ///  The position of the node to be deleted.
    ///</param>
    ///<exception cref="ArgumentOutOfRangeException">
    ///  Thrown when the provided position is out of range.
    ///</exception>
    public void DeleteNodeAt(int position){
        if(position < Length && position >= 0){
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

    ///<summary>
    ///  Gets the node at the specified position in the linked list.
    ///</summary>
    ///<param name="position">
    ///  The position of the node to be retrieved.
    ///</param>
    ///<returns>
    ///  The node at the specified position.
    ///</returns>
    ///<exception cref="ArgumentOutOfRangeException">
    ///  Thrown when the provided position is out of range.
    ///</exception>
    private Node? _GetNodeAt(int position){
        if(position < Length && position >= 0){
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

    ///<summary>
    ///  Inserts the node with the specified data at the specified position in the linked list.
    ///</summary>
    ///<param name="position">
    ///  The position at which to insert the new element.
    ///</param>
    ///<param name="data">
    ///  The data of the new node that will be inserted.
    ///</param>
    ///<exception cref="ArgumentOutOfRangeException">
    ///  Thrown when the provided position is out of range.
    ///</exception>
    public void Insert(int position, T data){
        if(position < Length && position >= 0){
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
        else {
            throw new ArgumentOutOfRangeException("position");
        }
    }

    ///<summary>
    ///  Get the data that is stored at the specified node in the linked list.
    ///</summary>
    ///<param name="position">
    ///  The position of the node in the linked list.
    ///</param>
    ///<returns>
    ///  The node data.
    ///</returns>
    ///<exception cref="ArgumentOutOfRangeException">
    ///  Thrown when the provided position is out of range.
    ///</exception>
    public T? GetNodeDataAt(int position){
        if(position < Length && position >= 0){
            return _GetNodeAt(position)!.Data;
        }
        else {
            throw new ArgumentOutOfRangeException("position");
        }
    }

    ///<summary>
    ///  Represent a node of the linked list.
    ///</summary>
    private class Node 
    {
        ///<summary>
        ///  Gets or sets the data of the node.
        ///</summary>
        public T? Data { get; set; }

        ///<summary>
        ///  Gets or sets the reference to the next node.
        ///</summary>
        public Node? Next { get; set; }

        ///<summary>
        ///  Initializes a new instance of the Node class with the specified data.
        ///</summary>
        ///<param name="data">
        ///  The data to be stored in the node.
        ///</param>
        public Node(T data){
            Data = data;
            Next = default;
        }
    }
}
