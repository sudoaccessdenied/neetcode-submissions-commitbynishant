public class Solution {
    public List<string> operators = ["+","-","*","/"];
    public int EvalRPN(string[] tokens) {
        var stack = new Stack<int>();
        for(int i =0;i< tokens.Length;i++){
            var curr = tokens[i];
            if( operators.Contains(curr)){
                var b = stack.Pop();
                var a = stack.Pop();
                var op = curr switch
                {
                    "+"=> a+b,
                    "-"=> a-b,
                    "*"=> a*b,
                    _ => a/b
                };
                stack.Push(op);
            }else{
                stack.Push(int.Parse(curr));
            }
        }
        return stack.Pop();
    }
}
