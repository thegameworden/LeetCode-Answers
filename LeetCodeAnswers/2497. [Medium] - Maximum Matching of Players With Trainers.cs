//This problem can be found at: https://leetcode.com/problems/maximum-matching-of-players-with-trainers

public class Solution {
    public int MatchPlayersAndTrainers(int[] players, int[] trainers) {
        PriorityQueue<int,int> qPlay = new();
        PriorityQueue<int,int> qTr = new();
        foreach(int i in players){
            qPlay.Enqueue(i,-i);
        }
        foreach(int i in trainers){
            qTr.Enqueue(i,-i);
        }
        int max=0;
        while(qPlay.Count!=0 && qTr.Count!=0){
            if(qPlay.Peek() <= qTr.Peek()){
                max++;
                qPlay.Dequeue();
                qTr.Dequeue();
            }else{
            qPlay.Dequeue();
            }

        }
        return max;
    }   
}
