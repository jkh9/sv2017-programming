//Jose Vilaplana
using System;

public class Encrypter
{
    public string Encrypt(string text)
    {
        string encrypted = "";
        foreach (char x in text)
        {
             encrypted = encrypted + (char)(x+1);           
        }
        return encrypted;
    }
    
    public string Decrypt(string text)
    {
        string decrypted = "";
        foreach (char x in text)
        {
              decrypted = decrypted + (char)(x-1);           
        }
        return decrypted;
    }
}

public class EncrypterTest
{
    public static void Main()
    {
        Encrypter eTest = new Encrypter();
        string text = "hola";
        string encrypted = eTest.Encrypt(text);
        
        Console.WriteLine(encrypted);
        Console.WriteLine(eTest.Decrypt(encrypted));
    }
}
