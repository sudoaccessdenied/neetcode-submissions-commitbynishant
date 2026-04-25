public class MyHashMap {

    private const int bucketSize = 10001;
    private int[] hash;
    public MyHashMap() {
       hash = new int[bucketSize]; 
       Array.Fill(hash,-1);
    }
    
    public void Put(int key, int value) {
        hash[GetIndex(key)] = value;
    }
    
    public int Get(int key) {
        return hash[GetIndex(key)];
    }
    
    public void Remove(int key) {
        hash[GetIndex(key)]=-1;
    }
    private int GetIndex(int key){
        return key%bucketSize;
    }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */