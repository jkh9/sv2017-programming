// Count spaces in a binary file

using System;
using System.IO;

public class CountSpaces
{
    public static void Main()
    {
        Console.Write("Enter file name: ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found!");
        }
        else
        {
            FileStream myFile = File.OpenRead(filename);
            int count = 0;
            for (int i = 0; i < myFile.Length; i++)
            {
                byte data = (byte) myFile.ReadByte();
                if (data == ' ') 
                    count ++;
            }
            myFile.Close();
            Console.WriteLine("Spaces: "+count);
        }
    }
}
