/*
Create a function to calculate the number of vowels (both uppercase and 
lowercase) and spaces in a text string. It will accept three parameters: the 
string to analyze, the variable to return the amount of vowels and the variable 
to return the amount of spaces, in this order. The function should be named 
“CountVS”. It would be used in a very similar  way to:

CountVS ("This is THE SENTENCE", amountOfVowels, amountOfSpaces)

amountOfVowels would be 6 and amountOfSpaces would be 3
*/

// Javier Saorin

using System;

public class Functions
{
    public static void CountVS(string sentence, 
        out int amountOfVowels, out int amountOfSpaces)
    {
        amountOfVowels = 0;
        amountOfSpaces = 0;
        foreach (char s in sentence.ToLower())
        {
            if (s == ' ')
                amountOfSpaces++;
            else if (s == 'a' || s == 'e' || s == 'i' 
                    || s == 'o' || s == 'u')
                amountOfVowels++;
        }
    }

    public static void Main()
    {
        int amountOfVowels, amountOfSpaces;

        CountVS("THIS is The SENTENCE", out amountOfVowels, out amountOfSpaces);

        Console.WriteLine("Vowels: " + amountOfVowels);
        Console.WriteLine("Spaces: " + amountOfSpaces);
    }
}
