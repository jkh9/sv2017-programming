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

//Angel Rebollo Berna

using System;

public class Ex355
{

    public static bool IsBalanced(string phrase)
    {
        int p1 = 0;

        foreach (char c in phrase)
        {
            if (c == '(')
            {
                p1++;
            }

            if (c == ')')
            {
                p1--;
                if (p1 < 0)
                    return false;
            }
        }

        if (p1 == 0)
            return true;
        else
            return false;
    }

    public static void Main()
    {
        Console.WriteLine("Phrase? ");
        string phrase = Console.ReadLine();

        if (IsBalanced(phrase))
            Console.WriteLine("OK");
        else
            Console.WriteLine("ERROR");
    }
}
