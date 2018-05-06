// 100%
public class Solution {
    public int CalPoints(string[] ops) {
        if(ops == null)
            return 0;
        
        int sum = 0;
        Stack<int> points = new Stack<int>();
        foreach(var op in ops){            
            if(int.TryParse(op, out int d)){
                points.Push(d);
                sum+=d;
            }
            else if (op == "C"){
                sum -= points.Pop();
            }
            else if (op == "D"){
                int t = points.Peek() * 2;
                sum += t;
                points.Push(t);
            }
            else if (op == "+"){
                int lr = points.Pop();
                int r = lr + points.Peek();
                points.Push(lr);
                points.Push(r);
                sum += r;
            }
            else
                throw new ApplicationException($"Unkown operator {op}");
        }                
        
        return sum;
    }
}