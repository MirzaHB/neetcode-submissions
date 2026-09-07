public class Solution {
    public int IslandPerimeter(int[][] grid) {
        int row = grid.Length;
        int col = grid[0].Length;
        int ans = 0;
        HashSet<(int,int)> set = new();
        Queue<(int,int)> q = new();
        int[][] directions = {[-1,0], [1,0], [0,-1], [0,1]};

        for(int r=0; r<row; r++)
            for(int c=0; c<col; c++)
                if(grid[r][c] == 1){
                    q.Enqueue((r,c));
                    set.Add((r,c));
                    bfs();
                    return ans;
                }

        void bfs(){
            while(q.Any()){
                var qlen = q.Count;
                for(int i=0; i<qlen; i++){
                    var (r,c) = q.Dequeue();
                    int numNeighbours = 0;
                    foreach(var dir in directions){
                        var nr = r+dir[0];
                        var nc = c+dir[1];
                        if(set.Contains((nr,nc))) numNeighbours +=1;
                        if(Math.Min(nr,nc)<0 || nr>=row || nc>=col || set.Contains((nr,nc))) continue;
                        if(grid[nr][nc]==1){
                            set.Add((nr,nc));
                            q.Enqueue((nr,nc));
                            numNeighbours +=1;
                        }
                    }
                    ans+=4-numNeighbours;
                }
            }
        }
        return 0;
    }
}