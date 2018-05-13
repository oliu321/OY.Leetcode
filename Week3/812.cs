public class Solution {
    public double LargestTriangleArea(int[][] points) {
        double max = 0.0;
        for(int i = 0; i < points.Length; ++i){
            for (int j = i + 1; j < points.Length; ++j){
                for (int k = j + 1; k < points.Length; ++k){
                    double cur = Area(points, i, j, k);
                    if (cur > max)
                        max = cur;
                }
            }
        }
        return max;
    }
    public double Area(int[][] points, int x, int y, int z){
        double a = Distance(points, x, y), b = Distance(points, y, z), c = Distance(points, z, x);
        double s = (a+b+c)/2;
        return Math.Sqrt(s * (s-a) * (s-b) * (s-c));
    }
    public double Distance(int[][] points, int x, int y){
        if (x == y)
            return 0.0;
        return Math.Sqrt((points[x][0] - points[y][0]) * (points[x][0] - points[y][0]) + (points[x][1] - points[y][1]) * (points[x][1] - points[y][1]));
    }
}