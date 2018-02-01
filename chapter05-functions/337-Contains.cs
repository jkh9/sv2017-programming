/*
Create two functions to return if a string contains a 
certain character. The first function must do it in an 
iterative way (NOT recursive, but using “for” o “while”),
and must be called “Contains”. The second function must 
do it in a recursive way (not using a "for" nor "while"), 
and must be called “ContainsR”. (2 points). 

An example of usage might be:

if ( Contains( "Hola" ,'a' ) ) Console.Write("There is an A");

Write ( ContainsR( "Hola", 'b') );
*/

//Moisés Encinas Picazo

using System;

class Program
{
    static void Main()
    {
        if (Contains("Hola", 'a')) Console.WriteLine("There is an A");

        Console.WriteLine(ContainsR("Hola", 'b'));
    }

    static bool Contains(string word,char letter )
    {
        foreach (char item in word)
        {
            if (letter == item)
            {
                return true;
            }
        }
        return false;
    }

    static bool ContainsR(string word, char letter)
    {
        // Base case: first letter
        if (word[0] == letter)
        {
            return true;
        }
        else if ((word.Length == 1) && (word[0] != letter))
        {
            return false;
        }
        // General case: remainder
        else
        {
            return ContainsR(word.Substring(1), letter);
        }
    }
}
