//This problem can be found at: https://leetcode.com/problems/fizz-buzz

public class Solution {
    public IList<string> FizzBuzz(int n) {
        List<string> answer = new List<string>();
        for(int i=1;i<=n;i++){
            StringBuilder sb = new StringBuilder();
            if(i%3==0){
                sb.Append("Fizz");
               
            }
            if(i%5==0){
                sb.Append("Buzz");
            }
            if(sb.Length==0)
                sb.Append(i.ToString());

                answer.Add(sb.ToString());
        }
        return answer;
    }
}
