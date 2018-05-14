// 31.46%, maybe should try DFS/BFS?
public class Solution {
    public class MySet{
        public int Size = 0;
        public MySet Root = null;
        public MySet(){
            this.Root = this;
            this.Size = 1;
        }
        public MySet Find(){
            if(this.Root == this)
                return this;
            this.Root = this.Root.Find();
            return this.Root;
        }
        public MySet Merge(MySet other){
            if(other == null)
                return this;
            other = other.Find();
            var me = this.Find();
            if (other == me)
                return other;
            
            if(other.Size > me.Size){
                me.Root = other;
                other.Size += me.Size;
                me.Size = other.Size;
                return other;
            }
            else{
                other.Root = me;
                me.Size += other.Size;
                other.Size = me.Size;
                return me;
            }
        }
    }
    public int MaxAreaOfIsland(int[,] grid) {
        int l1 = grid.GetLength(0);
        int l2 = grid.GetLength(1);
        MySet[,] sets = new MySet[l1, l2];
        int max = 0;
        for(int i = 0; i < l1; ++i)
            for (int j = 0; j < l2; ++j)
            {
                if(grid[i,j] == 0)
                    continue;
                
                MySet cur = null;                 
                cur = new MySet();
                sets[i,j] = cur;               
                
                if (i > 0)
                    cur = cur.Merge(sets[i-1, j]);
                if (j > 0)
                    cur = cur.Merge(sets[i, j - 1]);
                
                if (cur.Size > max)
                    max = cur.Size;
            }
        
        return max;
    }
}