using System;
using System.Text;

public class Encrypter
{

    public static string Encrypt(string s)
    {
        StringBuilder sb = new StringBuilder(s);
        for (int i = 0; i < s.Length; i++)
        {
            sb[i]++;
        }
        return sb.ToString();
    }

    public static string Decrypt(string s)
    {
        StringBuilder sb = new StringBuilder(s);
        for (int i = 0; i < s.Length; i++)
        {
            sb[i]--;
        }
        return sb.ToString();
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
