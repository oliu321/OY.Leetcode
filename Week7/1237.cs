/*
 * // This is the custom function interface.
 * // You should not implement it, or speculate about its implementation
 * public class CustomFunction {
 *     // Returns f(x, y) for any given positive integers x and y.
 *     // Note that f(x, y) is increasing with respect to both x and y.
 *     // i.e. f(x, y) < f(x + 1, y), f(x, y) < f(x, y + 1)
 *     public int f(int x, int y);
 * };
 */

public class Solution {
    public IList<IList<int>> FindSolution(CustomFunction customfunction, int z)	{
                List<IList<int>> r = new List<IList<int>>();
                int i = 1000; int j = 1;
                while (i >= 1 && j <= 1000)
                {
                    int f = customfunction.f(i, j);
                    if (f < z)
                    {
                        ++j;
                    }
                    else if (f == z)
                    {
                        List<int> rr = new List<int>();
                        rr.Add(i); rr.Add(j); r.Add(rr);
                        --i;
                    }
                    else
                        --i;
                }
                return r;
         }
