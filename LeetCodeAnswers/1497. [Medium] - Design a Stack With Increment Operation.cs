//This problem can be found at: https://leetcode.com/problems/design-a-stack-with-increment-operation

public class CustomStack {
    int size;
    Stack<int> customStack;
    public CustomStack(int maxSize) {
        size= maxSize;
        customStack = new Stack<int>();
    }
    
    public void Push(int x) {
        if(customStack.Count<size){
            customStack.Push(x);
        }
    }
    
    public int Pop() {
        if(customStack.Count==0)
            return -1;
        
        return customStack.Pop();
    }
    
    public void Increment(int k, int val) {
        Stack<int> tempS = new Stack<int>();
        while(customStack.Count!=0){
            tempS.Push(customStack.Pop());
        }
        
        for(int i=0;i<k;i++){
            if(tempS.Count==0){
                break;
            }
            customStack.Push(tempS.Pop()+val);
        }
        
        while(tempS.Count!=0){
            customStack.Push(tempS.Pop());
        }
    }
}

/**
 * Your CustomStack object will be instantiated and called as such:
 * CustomStack obj = new CustomStack(maxSize);
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * obj.Increment(k,val);
 */
