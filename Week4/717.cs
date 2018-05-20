// 88.51%
public class Solution {
    public bool IsOneBitCharacter(int[] bits) {
        if(bits == null || bits.Length == 1)
            return true;
        if (bits.Length == 2)
            return bits[0] == 0;
        
        bool[] status = new bool[bits.Length];
        status[0] = (bits[0] == 0);
        if (status[0])
            status[1] = (bits[1] == 0);
        else
            status[1] = true;
        for (int i = 2; i < bits.Length; ++i){
            if(bits[i] == 0){
                if (status[i - 1])
                    status[i] = true;
                else if (bits[i - 1] == 1)
                    status[i] = status[i - 2];
                else
                    status[i] = false;
            }
            else if (bits[i - 1] == 1)
                status[i] = status[i - 2];
            else 
                status[i] = false;
        }
        
        return status[bits.Length - 2]; 
    }
}