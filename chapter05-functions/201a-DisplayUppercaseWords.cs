// Javier Saorín Vidal

using System;

public class Ex201
{
    public static void DisplayUppercaseWords(string sentence)
    {
        string[] words = sentence.Split();

        for (int i = 0; i < words.Length; i++)
        {
            words[i] = words[i].Substring(0, 1).ToUpper() + 
                words[i].Substring(1, words[i].Length -1).ToLower();
        }

        foreach (string w in words)
        {
            Console.Write(w + " ");
        }
        Console.WriteLine();
    }
    public static void Main()
    {
        DisplayUppercaseWords("hola como estAs");
    }
}
