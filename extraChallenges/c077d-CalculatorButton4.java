/*
Calculator Button

Your calculator has a mysteriously unmarked button, that you suspect is either 
a plus (+) or a times (x). If you press the button between two numbers, and 
examine the calculator's output, you could find out what the button could be.

Task

Write a program that determines which button it can be: a plus (+) or times (x) 
button. Your program should read in three numbers: the first two being the 
numbers entered into the calculator along with the mysterious button and the 
last number, being the calculator's answer.

If the button can be either a plus or times button, output "Plus or Times". If 
the button can only be a plus or only be a times button, output which one it 
can be ("Plus only" or "Times only"). If it can be neither plus nor times, 
output "Neither Plus nor Times". Lastly, output both the plus and times 
equations.

Sample Run 
 
Input

First number: 4 
Second number: 2 
Answer: 6

Output

Plus only
4+2=6
4x2=8
*/

//package javachallenges;

import java.util.Scanner;

/**
 *
 * @author Moises Encinas
 */ 
public class CalculatorButton4
{
    public static void main(String[] args)
    {
        Scanner sc = new Scanner(System.in);
        
        System.out.print("First number: ");
        int n1 = sc.nextInt();
        
        System.out.print("Second number: ");
        int n2 = sc.nextInt();
        
        System.out.print("Answer: ");
        int answer = sc.nextInt();
        
        if((n1+n2) == answer && (n1*n2)== answer)
        {
            System.out.println("Plus or Times");
        }
        else if((n1+n2) == answer)
        {
            System.out.println("Plus only");
        }
        else if((n1*n2)== answer)
        {
            System.out.println("Times only");
        }
        else
        {
            System.out.println("Neither Plus nor Times");
        }
            
        
        System.out.println(n1+"+"+n2+"="+(n1+n2));
        System.out.println(n1+"x"+n2+"="+(n1*n2));
    }
}
