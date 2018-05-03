// 93.60%
public class Solution {
    public int CalPoints(string[] ops) {
        if(ops == null)
            return 0;
        
        Stack<int> points = new Stack<int>();
        foreach(var op in ops){            
            if(int.TryParse(op, out int d)){
                points.Push(d);
            }
            else if (op == "C"){
                points.Pop();
            }
            else if (op == "D"){
                points.Push(points.Peek() * 2);
            }
            else if (op == "+"){
                int lr = points.Pop();
                int r = lr + points.Peek();
                points.Push(lr);
                points.Push(r);
            }
            else
                throw new ApplicationException($"Unkown operator {op}");
        }
        
        int sum = 0;
        foreach(var p in points){
            sum += p;
        }
        return sum;
    }
}