//This problem can be found at: https://leetcode.com/problems/number-of-equivalent-domino-pairs

public class Solution {
    public int NumEquivDominoPairs(int[][] dominoes) {
        Dictionary<int[],int> pairs= new Dictionary<int[],int>(new SequenceEqualityComparer<int>());
        int pairCount=0;
        foreach(int[] dom in dominoes){
            int min = Math.Min(dom[0],dom[1]);
            int max = Math.Max(dom[0],dom[1]);
            int[] keyCheck = new int[]{min,max};
            if(pairs.ContainsKey(keyCheck)){
                pairs[keyCheck]++;
            }else{
                pairs.Add(new int[]{min,max},1);
            }
            
       
    }
        foreach(KeyValuePair<int[],int> kvp in pairs){
            if(kvp.Value>1){
                if(kvp.Value>1){
                    int temp=0;
                 for(int i=1;i<kvp.Value;i++){
                     temp+=i;
                 }
                    pairCount+=temp;
            }
        }
        
    }
    return pairCount;
}
}

    public class SequenceEqualityComparer<T> : IEqualityComparer<IEnumerable<T>> {
  public bool Equals(IEnumerable<T> x, IEnumerable<T> y) {
    if (ReferenceEquals(x, y))
      return true;
    else if (null == x || null == y)
      return false;

    return Enumerable.SequenceEqual(x, y, EqualityComparer<T>.Default); 
  }

  public int GetHashCode(IEnumerable<T> obj) =>
    obj == null ? 0 : obj.FirstOrDefault()?.GetHashCode() ?? 0;
}


/*
1 1 1 1 1

1:0
2:1
3:3
4:6
5:10
6: 15

*/

