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

//Almudena López Sánchez

using System;

public class Challenge77
{
    public static void Main()
    {
        Console.Write("First number: ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Second number: ");
        int n2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Answer: ");
        int answer = Convert.ToInt32(Console.ReadLine());

        int sum = n1 + n2;
        int mult = n1 * n2;

        if (sum == mult && sum == answer)
            Console.WriteLine("Plus or Times");
        else if (sum == answer)
            Console.WriteLine("Plus only");
        else if (mult == answer)
            Console.WriteLine("Times only");
        else
            Console.WriteLine("Neither Plus nor Times");

        Console.WriteLine(n1 + "+" + n2 + "=" + sum);
        Console.WriteLine(n1 + "x" + n2 + "=" + mult);
    }
}
