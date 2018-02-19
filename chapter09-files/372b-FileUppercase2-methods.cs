/*
Create a program to dump the contents of a 
text file "input.txt" into a  second file 
"output.txt", turning all the lines to uppercase.
*/

// Version 2: Using the statc methods of File

using System.IO;

public class FileUppercase
{
    public static void Main()
    {
        StreamReader input = File.OpenText("input.txt");
        StreamWriter output = File.CreateText("output.txt");
        string line;
        do 
        {
            line = input.ReadLine();
            if (line != null)
            {
                output.WriteLine(line.ToUpper());
            }
        }
        while(line != null);
        input.Close();
        output.Close();
    }
}
