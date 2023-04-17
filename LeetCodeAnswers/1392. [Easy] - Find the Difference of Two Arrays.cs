//This problem can be found at: https://leetcode.com/problems/find-the-difference-of-two-arrays

public class Solution {
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2) {
        List<IList<int>> answer = new List<IList<int>>();
        HashSet<int> h1 = new HashSet<int>();
        HashSet<int> h2 = new HashSet<int>();
        for(int i=0;i<nums1.Length;i++){
                h1.Add(nums1[i]);
        }
        for(int i=0;i<nums2.Length;i++){
                h2.Add(nums2[i]);
        }

        answer.Add(new List<int>());
        answer.Add(new List<int>());

        foreach(int i in nums2){   //try to add nums2 to h1
            if(h1.Add(i))
            answer[1].Add(i);
        }

        foreach(int i in nums1){   //try to add nums2 to h1
            if(h2.Add(i))
            answer[0].Add(i);
        }
        return answer;
    }
}
