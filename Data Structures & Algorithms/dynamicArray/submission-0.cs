public class DynamicArray {
    
    private int[] array;
    private int length ;
    public DynamicArray(int capacity) {
        array = new int[capacity];
        length = 0;
    }

    public int Get(int i) {
        return array[i];
    }

    public void Set(int i, int n) {
            array[i] =n;
    }

    public void PushBack(int n) {
        if(length == array.Length){
            Resize();
        }
        array[length] = n;
        length++;
    }

    public int PopBack() {
        var val= array[length-1];
        length--;
        return val;
    }

    private void Resize() {
        var newArray = new int[array.Length*2];
       for(int i = 0;i< array.Length;i++){
         newArray[i] = array[i];
       }
       array = newArray;
    }

    public int GetSize() {
        return length;
    }

    public int GetCapacity() {
        return array.Length;
    }
}
