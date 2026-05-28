public class Solution {
    public int CalPoints(string[] operations) {
        var stack = new Stack<int>();
        foreach(string str in operations){
            if(str == "+"){
                var b = stack.Pop();
                var a = stack.Peek();
                var sum = a+b;
                stack.Push(b);
                stack.Push(sum);
            }else if(str == "C"){
                stack.Pop();
            }else if(str =="D"){
                var b = stack.Peek();
                stack.Push(b*2);
            }else{
                if(int.TryParse(str, out var val)){
                    stack.Push(val);
                }
            }
        }
        var finalSum = 0;
        while(stack.Count > 0){
            finalSum+= stack.Pop();
        }
        return finalSum;
        
    }
}