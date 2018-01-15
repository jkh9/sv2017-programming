//Victor Tebar

using System;

public class Encrypter
{
    public static string Encrypt(string str)
    {
        string newStr = "";
        foreach(char c in str)
        {
            newStr += (char)(c + 1);
        }
        return newStr;
    }
    
    public static string Decrypt(string str)
    {
        string newStr = "";
        foreach(char c in str)
        {
            newStr += (char)(c - 1);
        }
        return newStr;
    }
}

public class EncrypterTest
{
    public static void Main()
    {
        string newText = Encrypter.Encrypt("Hola");
        Console.WriteLine(newText);
        Console.WriteLine(Encrypter.Decrypt(newText));
    }
}
