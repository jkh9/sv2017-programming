// Gonzalo Martinez

using System;

public class Encrypter
{
    
    public static string Encrypt(string s)
    {
        string encrypted = "";
        
        for(int i = 0; i < s.Length; i++)
        {
            encrypted = encrypted + Convert.ToChar(s[i] + 1);
        }
        return encrypted;
    }
    
    public static string Decrypt(string s)
    {
        string decrypted = "";
        
        for(int i = 0; i < s.Length; i++)
        {
            decrypted = decrypted + Convert.ToChar(s[i] - 1);
        }
        return decrypted;
    }
}

public class EncrypterTest
{
    public static void Main()
    {
        string newText = Encrypter.Encrypt("Hola");
        Console.WriteLine(newText);
        
        string textDecrypted = Encrypter.Decrypt(newText);
        Console.WriteLine(textDecrypted);
        
    }
}
