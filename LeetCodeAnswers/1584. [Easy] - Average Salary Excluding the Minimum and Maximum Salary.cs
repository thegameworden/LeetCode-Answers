//This problem can be found at: https://leetcode.com/problems/average-salary-excluding-the-minimum-and-maximum-salary

public class Solution {
    public double Average(int[] salary) {
        int min = salary[0];
        int max = salary[0];

        double ret = 0;
        for(int i=0;i<salary.Length;i++){
            if(salary[i]<min){
                min = salary[i];
                
            }else if(salary[i]>max){
                max = salary[i];  
            }
                ret+=(double)salary[i];
                Console.WriteLine(ret);
        }
        ret=ret-(double)min-(double)max;
         
return ret/(double)(salary.Length-2);


    }
}
