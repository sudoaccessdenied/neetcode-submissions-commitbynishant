public class Solution {
    public bool IsValid(string s) {
        if(s.Length == 0) return true;
        if(s.Length %2 !=0) return false;
        var stack = new Stack<char>();
        stack.Push(s[0]);
        if(s[0] == ']' || s[0] =='}' || s[0] ==')'){
            return false;
        }
        var i = 1;
        while(i< s.Length){
            var curr = s[i];
            if(curr == '[' || curr =='(' || curr =='{'){
                stack.Push(curr);
                i++;
                continue;
               
            }
            if(stack.Count == 0){
                return false;
            }
            var top = stack.Peek();
            // Console.WriteLine("Top "+top);
            if(top == ']' || top =='}' || top ==')' || top == null){
                return false;
            }
            if( (top=='(' &&  curr != ')')  || (top=='[' && curr!=']') || (top == '{' && curr != '}')){
                return false;
            }    
            stack.Pop();
            i++;
            
        }
        if(stack.Count == 0) return true;
        return false;
        
    }
}
