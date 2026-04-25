public class MyHashSet {

    private const int bucketSize = 10000;
    private int[] hash;

    public MyHashSet() {
        hash = new int[bucketSize];
        Array.Fill(hash,-1);
    }
    
    public void Add(int key) {
        var index = key % bucketSize;
        hash[index] = key;
    }
    
    public void Remove(int key) {
       var index = key % bucketSize;
       hash[index] = -1;
    }
    
    public bool Contains(int key) {
        var index = key % bucketSize;
        if(hash[index] >= 0){
            return true;
        }
        return false;
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */