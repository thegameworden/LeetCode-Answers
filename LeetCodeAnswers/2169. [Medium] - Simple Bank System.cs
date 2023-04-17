//This problem can be found at: https://leetcode.com/problems/simple-bank-system

public class Bank {
    long[] bankAcc;
    public Bank(long[] balance) {
        bankAcc = balance;
        Console.WriteLine(bankAcc[0]);
    }
    
    public bool Transfer(int account1, int account2, long money) {
        account1--;
        account2--;
        if(account1<0 ||account1>= bankAcc.Length || account2<0 || account2 >=bankAcc.Length ||money>bankAcc[account1]){
            return false;
        }
        bankAcc[account1]-=money;
        bankAcc[account2]+=money;
        return true;

    }
    
    public bool Deposit(int account, long money) {
        account--;
        if(account<0 || account>=bankAcc.Length){
            return false;
        }
        bankAcc[account]+=money;
        return true;
    }
    
    public bool Withdraw(int account, long money) {
        account--;
        if(account<0 || account>=bankAcc.Length || bankAcc[account]<money){
            return false;
        }
        bankAcc[account]-=money;
        return true;
    }
}

/**
 * Your Bank object will be instantiated and called as such:
 * Bank obj = new Bank(balance);
 * bool param_1 = obj.Transfer(account1,account2,money);
 * bool param_2 = obj.Deposit(account,money);
 * bool param_3 = obj.Withdraw(account,money);
 */
