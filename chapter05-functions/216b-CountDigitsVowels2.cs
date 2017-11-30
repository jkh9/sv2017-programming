// Example of out parameters:
// CountDigitsAndVowels2

using System;

public class CountDigitsAndVowels2
{
    public static void CountDigitsVowels(string text, 
            out int amountOfDigits, out int amountOfVowels)
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
        int digits,vowels;
        CountDigitsVowels("This is THE 1st SENTENCE", 
            out digits, out vowels);
        Console.WriteLine("Digits: " + digits);
        Console.WriteLine("Vowels: " + vowels);
    }
}
