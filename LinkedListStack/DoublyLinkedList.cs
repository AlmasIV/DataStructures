namespace DoublyLinkedList;

///<summary>
///  Represents the doubly linked list data type.
///</summary>
///<typeparam name="T">
///  The type of elements in the doubly linked list.
///</typeparam>
public class DoublyLinkedList<T> {

    ///<summary>
    ///  Gets or sets the head node.
    ///</summary>
    private Node? _head { get; set; }

    ///<summary>
    ///  Gets or sets the tail node.
    ///</summary>
    private Node? _tail { get; set; }

    ///<summary>
    ///  Gets the length of the doubly linked list.
    ///</summary>
    public int Length { get; private set; } = 0;

    ///<summary>
    ///  Adds a new node to the end of the doubly linked list.
    ///</summary>
    ///<param name="data">
    ///  The data of the node.
    ///</param>
    public void Add(T? data){
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

    ///<summary>
    ///  Inserts a new node at the specified index in the doubly linked list.
    ///</summary>
    ///<param name="index">
    ///  The index at which to insert a new node.
    ///</param>
    ///<param name="data">
    ///  The data of the new node.
    ///</param>
    ///<exception cref="ArgumentOutOfRangeException">
    ///  Thrown when the provided index is out of range.
    ///</exception>
    public void Insert(int index, T? data){
        if(index >= 0 && index <= Length){
            if(index == Length){
                this.Add(data);
            }
            else{
                Node currentNode = _GetNodeAt(index)!;
                if(index == 0){
                    _head = new Node(data);
                    currentNode.Previous = _head;
                    _head.Next = currentNode;
                }
                else{
                    currentNode.Previous = new Node(data);
                    currentNode.Previous.Next = currentNode;
                }
            }
            Length ++;
        }   
        else{
            throw new ArgumentOutOfRangeException("index");
        }
    }

    ///<summary>
    ///  Removes an existing node at the specified index.
    ///</summary>
    ///<param name="index">
    ///  The index at which to delete an existing new node.
    ///</param>
    ///<exception cref="ArgumentOutOfRangeException">
    ///  Thrown when the provided index is out of range.
    ///</exception>
    public void RemoveAt(int index){
        if(index >= 0 && index < Length){
            Node removedNode = _GetNodeAt(index);
            if(removedNode == _head){
                _head = _head.Next;
            }
            else if(removedNode == _tail){
                _tail = _tail.Previous;
            }
            else{
                removedNode.Previous!.Next = removedNode.Next;
            }
            Length --;
        }
        else{
            throw new ArgumentOutOfRangeException("index");
        }
    }

    ///<summary>
    ///  Removes the last element from the doubly-linked list, and returns it.
    ///</summary>
    ///<returns>
    ///  Removed node's data.
    ///</reutrns>
    ///<exception cref="InvalidOperationException">
    ///  Thrown when the doubly-linked list is empty.
    ///</exception>
    public T? Pop(){
        if(Length > 0){
            Node? result = _GetNodeAtReversed(Length - 1);
            _tail = _tail!.Previous;
            Length --;
            return result.Data;
        }
        else{
            throw new InvalidOperationException("The doubly-linked list is empty.");
        }
    }

    ///<summary>
    ///  Gets the node's data at the specified position.
    ///</summary>
    ///<param name="index">
    ///  The index at which to retrieve the data.
    ///</param>
    ///<returns>
    ///  The node data.
    ///</returns>
    ///<exception cref="ArgumentOutOfRangeException">
    ///  Thrown when the provided index is out of range.
    ///</exception>
    public T? GetData(int index){
        if(index >= 0 && index < Length){
            return _GetNodeAt(index).Data;
        }
        throw new ArgumentOutOfRangeException("index");
    }

    ///<summary>
    ///  Gets the node's data at the specified position. The position starts from the end.
    ///</summary>
    ///<param name="index">
    ///  The index at which to retrieve the data.
    ///</param>
    ///<returns>
    ///  The node data.
    ///</returns>
    ///<exception cref="ArgumentOutOfRangeException">
    ///  Thrown when the provided index is out of range.
    ///</exception>
    public T? GetDataReversed(int index){
        if(index >= 0 && index < Length){
            return _GetNodeAtReversed(index).Data;
        }
        throw new ArgumentOutOfRangeException("index");
    }

    ///<summary>
    ///  Gets a node at the specified index, and returns it.
    ///</summary>
    ///<param name="index">
    ///  The index at which to retrieve a node's data.
    ///</param>
    ///<exception cref="ArgumentOutOfRangeException">
    ///  Thrown when the provided index is out of range.
    ///</exception>
    private Node _GetNodeAt(int index){
        if(index >= 0 && index < Length){
            int counter = 0;
            Node tempNode = _head;
            while(tempNode != null){
                if(counter == index){
                    return tempNode;
                }
                tempNode = tempNode.Next;
                counter ++;
            }
        }
        throw new ArgumentOutOfRangeException("index");
    }

    ///<summary>
    ///  Gets a node at the specified index, and returns it. Starts from the end.
    ///</summary>
    ///<param name="index">
    ///  The index at which to retrieve a node's data.
    ///</param>
    ///<exception cref="ArgumentOutOfRangeException">
    ///  Thrown when the provided index is out of range.
    ///</exception>
    private Node _GetNodeAtReversed(int index){
        if(index >= 0 && index < Length){
            int counter = Length - 1;
            Node tempNode = _tail;
            while(tempNode != null){
                if(counter == index){
                    return tempNode;
                }
                tempNode = tempNode.Previous;
                counter --;
            }
        }
        throw new ArgumentOutOfRangeException("index");
    }

    ///<summary>
    ///  Represents a node of the doubly linked list.
    ///<summary>
    private class Node {

        ///<summary>
        ///  Gets or sets the data of the node.
        ///</summary>
        public T? Data { get; set; }

        ///<summary>
        ///  Gets or sets the next node.
        ///</summary>
        public Node? Next { get; set; }

        ///<summary>
        ///  Gets or sets the previous node.
        ///</summary>
        public Node? Previous { get; set; }

        ///<summary>
        ///  Initializes a new node with the specified data.
        ///</summary>
        ///<param name="data">
        ///  The data that the node holds.
        ///</param>
        public Node(T? data){
            Data = data;
            Next = default;
            Previous = default;
        }
    }
}