//Querubin Santana

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

public class CaesarEncrypter : Encrypter
{
    public new static string Encrypt(string s)
    {
        // Note: this approach might fail with uppercase chars
        // and other sumbols
        StringBuilder sb = new StringBuilder(s);
        for (int i = 0; i < s.Length; i++)
        {
            
            if(sb[i] == 'z')
            {
                sb[i]='c';
            }
            else if(sb[i] == 'x')
            {
                sb[i]='b';
            }
            else if(sb[i] == 'y')
            {
                sb[i]='a';
            }
            else
            {
                sb[i]+=(char)3;
            }
        }
        return sb.ToString();
    }

    public new static string Decrypt(string s)
    {
        // Note: this approach might fail with uppercase chars
        // and other sumbols
        StringBuilder sb = new StringBuilder(s);
        for (int i = 0; i < s.Length; i++)
        {
            if(sb[i] == 'a')
            {
                sb[i]='y';
            }
            else if(sb[i] == 'b')
            {
                sb[i]='x';
            }
            else if(sb[i] == 'c')
            {
                sb[i]='z';
            }
            else
            {
                sb[i]-=(char)3;
            }
        }
        return sb.ToString();
    }
}

public class EncrypterTest
{
    public static void Main()
    {
        string newText = CaesarEncrypter.Encrypt("Hola");
        Console.WriteLine(newText);

        string textDecrypted = CaesarEncrypter.Decrypt(newText);
        Console.WriteLine(textDecrypted);

    }
}
