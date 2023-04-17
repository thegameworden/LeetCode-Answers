//This problem can be found at: https://leetcode.com/problems/keys-and-rooms

public class Solution {
    public bool CanVisitAllRooms(IList<IList<int>> rooms) {
       bool[] visited = new bool[rooms.Count];
        traverse(rooms, visited, 0);
        for(int i=0;i<visited.Length;i++){
            if(!visited[i])
            return false;
        }
        return true;
    }

    private void traverse(IList<IList<int>> rooms, bool[] visited, int room){
        if(visited[room]){
            return;
        }

        visited[room]=true;

        foreach(int r in rooms[room]){
            traverse(rooms,visited,r);
        }
    }
}
