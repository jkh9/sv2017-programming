using System;
using System.IO;

public class Files1To10
{
    public static void Main()
    {
        try
        {
            for (int i = 1; i <= 10; i++)
            {
                StreamWriter a = File.CreateText(i+".txt");
                a.WriteLine("This is the file #"+i);
                a.Close();
            }
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("Path too long");
        }
        catch (IOException e)
        {
            Console.WriteLine("I/O error: " + e);
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e);
        }

    }
}
