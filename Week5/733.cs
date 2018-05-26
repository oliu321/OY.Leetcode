// 68.42%
public class Solution {
    public int[,] FloodFill(int[,] image, int sr, int sc, int newColor) {
        int rc = image.GetLength(0);
        int scc = image.GetLength(1);
        int oldColor = image[sr, sc];
        Queue<int> vq = new Queue<int>();
        vq.Enqueue(sr * scc + sc);
        HashSet<int> visited = new HashSet<int>();
        while(vq.Count() > 0){
            int i = vq.Dequeue();
            visited.Add(i);
            sr = i / scc; sc = i % scc;
            image[sr, sc] = newColor;
            --sr;
            if (sr >= 0 && image[sr, sc] == oldColor && !visited.Contains(sr * scc + sc))
                vq.Enqueue(sr * scc + sc);
            sr += 2;
            if (sr < rc && image[sr, sc] == oldColor && !visited.Contains(sr * scc + sc))
                vq.Enqueue(sr * scc + sc);
            --sr; --sc;
            if (sc >= 0 && image[sr, sc] == oldColor && !visited.Contains(sr * scc + sc))
                vq.Enqueue(sr * scc + sc);
            sc += 2;
            if (sc < scc && image[sr, sc] == oldColor && !visited.Contains(sr * scc + sc))
                vq.Enqueue(sr * scc + sc);
        }
        return image;
    }
}