public class Solution {
    public int Divide(int dividend, int divisor) {
            if (divisor == 0)
                return int.MaxValue;
            if (dividend == 0)
                return 0;
            if (dividend == int.MinValue && divisor == -1)
                return int.MaxValue;            
            

            long dd = dividend < 0 ? -1 * (long) dividend : dividend, dr = divisor < 0 ? - 1 * (long) divisor : divisor;
            long r = 0;

            while(dd >= dr)
            {
                long ddr = dr;
                int i = 1;
                while(dd > (ddr+ddr))
                {
                    ddr += ddr;
                    i <<= 1;
                }

                r += i;
                dd -= ddr;
            }

            if (dividend < 0 && divisor > 0)
                return (int)(-1 * r);
            if (dividend > 0 && divisor < 0)
                return (int)(-1 * r);

            return (int)r;                   
        }
}