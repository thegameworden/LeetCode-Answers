//This problem can be found at: https://leetcode.com/problems/design-phone-directory

public class PhoneDirectory {
    bool[] usedPhones;
    public PhoneDirectory(int maxNumbers) {
        usedPhones = new bool[maxNumbers];
    }
    
    public int Get() {
        for(int i=0;i<usedPhones.Length;i++){
            if(!usedPhones[i]){
                usedPhones[i]=true;
                return i;
            }
        }
        return -1;
    }
    
    public bool Check(int number) {
        return !usedPhones[number];
    }
    
    public void Release(int number) {
        usedPhones[number]=false;
    }
}

/**
 * Your PhoneDirectory object will be instantiated and called as such:
 * PhoneDirectory obj = new PhoneDirectory(maxNumbers);
 * int param_1 = obj.Get();
 * bool param_2 = obj.Check(number);
 * obj.Release(number);
 */
