public class LinkedList {

    class Node{
        public Node Next {get;set;}
        public int Data {get;set;}

        public Node(Node next, int data){
            Next = next;
            Data = data;
        }
    }
    private Node _node;
    public LinkedList() {
        _node = new Node(null,-1);

    }

    public int Get(int index) {
        var itr = _node;
        for(int i =0;i<index;i++)
        {
            itr = itr.Next;
            if(itr == null) return -1;
        }
        var currNode = itr.Next;
        if(currNode == null) return -1;
        return currNode.Data;
    }

    public void InsertHead(int val) {
        var newNode = new Node(_node.Next, val);
        _node.Next = newNode;
    }

    public void InsertTail(int val) {
        var newNode = new Node(null, val);
        var itr = _node;
        while(itr.Next!= null){
            itr = itr.Next;
        }
        itr.Next = newNode;
    }

    public bool Remove(int index) {
        var itr = _node;
        for(int i =0;i<index;i++)
        {
            itr = itr.Next;
            if(itr == null) return false;
        }
        var currNode = itr.Next;
        if(currNode == null) return false;
        itr.Next = currNode.Next;   
        return true;
    }

    public List<int> GetValues() {
        var list = new List<int>();
        var itr = _node;
        while(itr!= null){
            itr = itr.Next;
            if(itr != null)
             list.Add(itr.Data);
        }
        return list;
        
    }
}