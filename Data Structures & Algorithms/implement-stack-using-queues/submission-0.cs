public class MyStack {
    private Queue<int> s1;
    private Queue<int> s2;
    public MyStack() {
        s1 = new Queue<int>();
        s2 = new Queue<int>();
    }
    
    public void Push(int x) {
        s2.Enqueue(x);
        while(s1.Count > 0){
            var t = s1.Dequeue();
            s2.Enqueue(t);
        }
        Queue<int> temp = s1;
        s1 = s2;
        s2= temp;
        
    }
    
    public int Pop() {
        return s1.Dequeue();
    }
    
    public int Top() {
       return s1.Peek();
    }
    
    public bool Empty() {
         return s1.Count == 0;
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
1. 1,2,3,4,5
2. 








 */

