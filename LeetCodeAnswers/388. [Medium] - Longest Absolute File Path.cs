//This problem can be found at: https://leetcode.com/problems/longest-absolute-file-path

public class Solution {
    public int LengthLongestPath(string input) {
        
        
        string[] lines = input.Split('\n');
        Dictionary<int,int> paths = new Dictionary<int,int>();
        paths.Add(0,0);
        int max=0;
        for(int i=0;i<lines.Length;i++){
           
            string line= lines[i];
            string name = line.TrimStart('\t');
            int depth = line.Length- name.Length+1;
            int length= paths[depth-1]+name.Length;
            Console.WriteLine(length);
            if(name.Contains('.')){
                max=Math.Max(max,length);
            }else{
                length++;
                if(paths.ContainsKey(depth)){
                    paths[depth]=length;
                }else{
                    paths.Add(depth,length);
                }
            }
        }
        
        
        return max;
        
    }
    
}

/*
dir
    \n\tsubdir1
    \n\t\t file1.ext
    \n\t\t subsubdir1
    
    \n\tsubdir2
    \n\t\t subsubdir2
*/
