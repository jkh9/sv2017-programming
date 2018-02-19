/*
Create a program to dump the contents of a 
text file "input.txt" into a  second file 
"output.txt", turning all the lines to uppercase.
*/

// Version 1: Using the constructors

using System.IO;

public class FileUppercase
{
    public static void Main()
    {
        StreamReader input = new StreamReader("input.txt");
        StreamWriter output = new StreamWriter("output.txt");
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
