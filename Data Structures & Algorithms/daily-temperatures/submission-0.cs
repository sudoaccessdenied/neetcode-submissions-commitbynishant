public class Solution {
    public int[] DailyTemperatures(int[] temp) {
        var stack = new Stack<int>();
        var result = new int[temp.Length];
        stack.Push(temp.Length-1);
        var n = temp.Length-1;
        for(int i=n-1;i>=0;i--){
            var curr = temp[i];
           
           while(stack.Count >0 && curr >= temp[stack.Peek()] ){
                stack.Pop();
            }
            if(stack.Count >0){
                result[i] = stack.Peek() -i;
            }
            stack.Push(i);
        }
        return result;        
    }
}
// temperatures = [30,38,30,36,35,40,28]
// stack = 40,28
// res = 1,_,1
// 