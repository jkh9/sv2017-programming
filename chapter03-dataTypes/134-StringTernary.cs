/*
Prepare a C# program to assign the variable "textMark" (string) the value 
"passed" if a numeric variable "mark" has a value of 60 or above and "not 
passed" if it is under 60. Do it two times: first using "if" and then using the 
ternary operator.
*/

// angel rebollo berna

using System;

public class Ex
{
    public static void Main()
    {
        string passed;
        int mark;
        
        Console.Write("Mark? ");
        mark = Convert.ToInt32(Console.ReadLine());
        
        if (mark >= 60)
            passed = "yes";
        else
            passed = "no";
        Console.WriteLine(passed);
        
        passed = mark >= 60 ? "yes" : "no";
        Console.WriteLine(passed);
    }
}
