/*
Ex. 358: Forth expressions evaluator

Forth is a computer programming language in which most operations are based on 
a stack.

The most representative example is that of numeric expressions, which are 
expressed in "reverse polish notation" (RPN), such as 2 3 +

The way to evaluate these expressions is as follows

- If a number is found, it is stored in the stack

- If an operator is found, two operands are taken from the stack, the result is 
  calculated and stored in the stack

- The simple operators are + - * / mod (for the remainder of the division)

- The command "." takes the value from the stack and displays it on console, 
  followed by " ok"

For example, "2 3 + ." [Enter] would display "5 ok" on screen

Also, "3 4 5 - * ." [Enter] would display "3 ok" (which is the result of 
(5-4)*3)

Create a program to evaluate (and perhaps display the results of) expressions 
like those.
*/

//Pedro Luis Coloma

using System;
using System.Collections;

public class Practica
{
    public static void Main()
    {
        Console.Write("Enter operation: ");
        string operation = Console.ReadLine();
        
        Stack myStack = new Stack();
        
        string[] parts = operation.Split(' ');
        int n1, n2;
        
        foreach (string data in parts)
        {
            switch(data)
            {
                case "+":
                    n1 =(int) myStack.Pop();
                    n2 =(int) myStack.Pop();
                    
                    myStack.Push(n1 + n2);
                    break;
                    
                case "-":
                    n1 =(int) myStack.Pop();
                    n2 =(int) myStack.Pop();
                    
                    myStack.Push(n1 - n2);
                    break;
                    
                case "/":
                    n1 =(int) myStack.Pop();
                    n2 =(int) myStack.Pop();
                    
                    myStack.Push(n1 / n2);
                    break;
                    
                case "*":
                    n1 =(int) myStack.Pop();
                    n2 =(int) myStack.Pop();
                    
                    myStack.Push(n1 * n2);
                    break;
                
                case "mod":
                    n1 =(int) myStack.Pop();
                    n2 =(int) myStack.Pop();
                    
                    myStack.Push(n1 % n2);
                    break;
                        
                case ".":
                    Console.WriteLine(myStack.Pop());
                    break;
                    
                default:
                    myStack.Push(Convert.ToInt32(data));
                    break;
            }
		}
    }
}
