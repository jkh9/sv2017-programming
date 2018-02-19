/*
Create a program to dump the contents of a 
text file "input.txt" into a  second file 
"output.txt", turning all the lines to uppercase.
*/

// Version 4: "while" instead of "do-while"

using System.IO;

public class FileUppercase
{
    public static void Main()
    {
        StreamReader input = new StreamReader("input.txt");
        StreamWriter output = new StreamWriter("output.txt");
        string line = input.ReadLine();
        while(line != null)
        {
            output.WriteLine(line.ToUpper());
            line = input.ReadLine();
        }
        input.Close();
        output.Close();
    }
}
