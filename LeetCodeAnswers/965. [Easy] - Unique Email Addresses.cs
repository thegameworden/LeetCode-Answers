//This problem can be found at: https://leetcode.com/problems/unique-email-addresses

public class Solution {
    public int NumUniqueEmails(string[] emails) {
        HashSet<string>  addresses = new HashSet<string>();
        for(int i=0;i<emails.Length;i++){
                addresses.Add(adjust(emails[i]));
        }
        
        return addresses.Count;
        
    }
    
    private string adjust(string address){
        string local = address.Substring(0,address.IndexOf('@'));
        string domain= address.Substring(address.IndexOf('@'), address.Length-address.IndexOf('@'));
        
        if(local.Contains('+')){
            local = local.Substring(0,local.IndexOf('+'));
        }
          
        local=local.Replace(".","");
    
        
        
        
        
        
        
        return local+domain;
    }
}
