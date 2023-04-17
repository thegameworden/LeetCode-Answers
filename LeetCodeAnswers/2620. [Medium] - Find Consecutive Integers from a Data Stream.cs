//This problem can be found at: https://leetcode.com/problems/find-consecutive-integers-from-a-data-stream

public class DataStream {
    List<int> stream;
    int streamVal;
    int lastRange;
    int latestWrong;
    public DataStream(int val, int k) {
        streamVal=val;
        lastRange=k;
        stream= new List<int>();
        latestWrong=-1;
    }
    
    public bool Consec(int num) {
        stream.Add(num);
        if(num!=streamVal){
            latestWrong=stream.Count;
        }
        
        if(stream.Count<lastRange)
            return false;
        
        if(latestWrong>stream.Count-lastRange)
            return false;
        
        return true;
    }
}

/**
 * Your DataStream object will be instantiated and called as such:
 * DataStream obj = new DataStream(value, k);
 * bool param_1 = obj.Consec(num);
 */
