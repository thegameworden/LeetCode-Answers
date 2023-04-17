//This problem can be found at: https://leetcode.com/problems/goal-parser-interpretation

public class Solution {
    public string Interpret(string command) {
        StringBuilder sb = new StringBuilder();

        int pointer = 0;
        while(pointer<command.Length){
            if(command[pointer]=='G'){     //G
                sb.Append("G");
                pointer++;
            }else{

                if(command[pointer+1]==')'){ //()
                    sb.Append("o");
                    pointer+=2;
                }else{                          //(al)
                    sb.Append("al");
                    pointer+=4;
                }
            }
        }

        return sb.ToString();
    }
}

/*
if char is G -> add g
    position++;

if char is '('
    if next char ')'
        add o
        position+2;
    else
        add al
        position+4
*/
