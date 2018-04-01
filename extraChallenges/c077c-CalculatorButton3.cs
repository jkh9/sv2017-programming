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

//by Renata Pestana Ribeiro

using System;

public class East_077
{
    public static void Main(string[] args)
    {
        string[] numStr = { "Neither Plus nor Times", "Plus only", 
                "Times only", "Plus or Times" };
        int num1, num2, answer, text =0;

        Console.Write("First number: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Answer: ");
        answer = Convert.ToInt32(Console.ReadLine());

        if (num1 + num2 == answer)
            text++;
        if (num1 * num2 == answer)
            if (text == 0)
                text = 2;
            else if(text == 1)
                text = 3;

        Console.WriteLine(numStr[text]);
        Console.WriteLine(num1 + "+" + num2 + "=" + (num1 + num2));
        Console.WriteLine(num1 + "x" + num2 + "=" + num1 * num2);
    }
}
