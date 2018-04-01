//Marcos Cervantes Matamoros
//Easter Challenges
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
output "Neither Plus nor Times". Lastly, output both the plus and times equations.

Sample Run Input
First number: 4 
Second number: 2 
Answer: 6

Output
Plus only
4+2=6
4x2=8

Test Your Program With

    5	6	11
    2	4	8
    2	2	4
    7	2	4
*/

using System;

public class EasterChallenge31th
{
    public static void Main()
    {
        bool plus = false;
        bool times = false;
        Console.Write("First number: ");
        double num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Second number: ");
        double num2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Answer number: ");
        double answer = Convert.ToInt32(Console.ReadLine());

        if (num1 + num2 == answer)
        {
            plus = true;
        }
        if (num1 * num2 == answer)
        {
            times = true;
        }

        Console.WriteLine();

        if(plus == true && times == true)
            Console.WriteLine("Plus or Times");
        else if(plus == true)
            Console.WriteLine("Plus only");
        else if(times == true)
            Console.WriteLine("Times only");
        else
            Console.WriteLine("Neither Plus nor Times");
        Console.WriteLine(num1 + "+" + num2 + "=" + (num1 + num2));
        Console.WriteLine(num1 + "x" + num2 + "=" + (num1 * num2));
        Console.WriteLine();
    }
}
