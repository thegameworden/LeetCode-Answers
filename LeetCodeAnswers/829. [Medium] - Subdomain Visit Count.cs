//This problem can be found at: https://leetcode.com/problems/subdomain-visit-count

public class Solution {
     Dictionary<string, int> check;

    public IList<string> SubdomainVisits(string[] cpdomains) {
       check = new();
        for(int i=0;i<cpdomains.Length;i++){
            parse(cpdomains[i]);
        }

        List<string> ret = new();
        foreach(KeyValuePair<string,int> kvp in check){
            ret.Add($"{kvp.Value} {kvp.Key}");
        }
        return ret;
    }

    private void parse(string str){
        string[] split = str.Split(' ');
        int num = Convert.ToInt32(split[0]);

        string[] domains = split[1].Split('.');

        string checker = "";
        for(int i=domains.Length-1;i>=0;i--){
            checker=domains[i]+ checker;
            if(check.ContainsKey(checker)){
                check[checker]+= num;
            }else{
                check.Add(checker,num);
            }

            checker= "."+checker;
        }
        
    }
}
