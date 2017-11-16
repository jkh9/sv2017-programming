// (Ex.187) StringBuilder, sort

// Ask the user for a sentence and sort the chars in it, using a 
// StringBuilder. Then display the resulting string on screen.

// Miguel Puerta

using System;
using System.Text;

public class Ex187
{
    public static void Main()
    {
        string text = Console.ReadLine();
        StringBuilder str = new StringBuilder(text);
        
        for(int i = 0; i < text.Length - 1; i++)
        {
            for(int j = i + 1; j < text.Length; j++)
            {
                if(str[i] > str[j])
                {
                    char aux = str[j];
                    str[j] = str[i];
                    str[i] = aux;
                }
            }
        }
        
        string result = str.ToString();
        Console.WriteLine(result);
    }
}
