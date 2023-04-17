//This problem can be found at: https://leetcode.com/problems/time-needed-to-buy-tickets

public class Solution {
    public int TimeRequiredToBuy(int[] tickets, int k) {
        int counter=0;
        for(int i=0;i<tickets.Length;i++){
            if(i<=k){
                if(tickets[i]<=tickets[k]){
                    counter+=tickets[i];
                }else{
                    counter+=tickets[k];
                }
            }else{
                if(tickets[i]<tickets[k]){
                    counter+=tickets[i];
                }else{
                    counter+=tickets[k]-1;
                }
        }
    }
     return counter;
}
}
