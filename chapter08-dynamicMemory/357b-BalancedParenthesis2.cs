/*
Ex.357 - Balanced parenthesis

Implement a function to check if a sequence of opened and closed parenthesis is 
balanced, that is, if each opened parenthesis corresponds to one closed 
parenthesis and they are also correctly nested.

The test program will accept a string from console and display OK or ERROR. You 
must show no previous message to the user.

It must behave correctly if there is any expression in the parenthesis.

For example:

(()()(())) 
OK

(((() 
ERROR

)()( 
ERROR

((2+3)*5) 
OK
*/

//Victor Tebar

using System;
using System.Collections;

public class Ejer357{
    public static bool CheckParenthesis(string cad){
        Stack stack = new Stack();
        
        for(int i=0;i < cad.Length;i++){
            if(cad[i] == '('){
                stack.Push('(');
            }
            else if(cad[i] == ')'){
                if(stack.Count > 0)
                    stack.Pop();
                else
                    return false;
            }
        }
        
        return (stack.Count == 0);
    }
    
    public static void Main(){
        string cad;
        
        cad = Console.ReadLine();
        
        if(CheckParenthesis(cad))
            Console.WriteLine("OK");
        else
            Console.WriteLine("ERROR");
    }
}
