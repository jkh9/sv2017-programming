// Example of ref parameters:
// CountDigitsAndVowels

using System;

public class CountDigitsAndVowels
{
    public static void CountDigitsVowels(string text, 
            ref int amountOfDigits, ref int amountOfVowels)
    {
        amountOfDigits = 0;
        amountOfVowels = 0;
        text = text.ToLower();
        foreach(char c in text)
        {
            if ((c >= '0') && (c <= '9'))
                amountOfDigits ++;
            
            else if ((c == 'a') || (c == 'e') || 
                    (c == 'i') || (c == 'o') || (c == 'u'))
                amountOfVowels ++;
        }
    }
    
    public static void Main()
    {
        int digits = 0;
        int vowels = 0;
        CountDigitsVowels("This is THE 1st SENTENCE", 
            ref digits, ref vowels);
        Console.WriteLine("Digits: " + digits);
        Console.WriteLine("Vowels: " + vowels);
    }
}
