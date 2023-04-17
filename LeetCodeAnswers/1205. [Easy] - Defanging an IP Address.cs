//This problem can be found at: https://leetcode.com/problems/defanging-an-ip-address

public class Solution {
    public string DefangIPaddr(string address) {
        StringBuilder sb = new StringBuilder();
        for(int i=0;i<address.Length;i++){
            if(address[i]=='.'){
                sb.Append("[.]");
            }else{
                sb.Append(address[i]);
            }
        }
        return sb.ToString();
    }
}
