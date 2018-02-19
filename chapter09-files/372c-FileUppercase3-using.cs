/*
Create a program to dump the contents of a 
text file "input.txt" into a  second file 
"output.txt", turning all the lines to uppercase.
*/

// Version 3: Using... "using"

using System.IO;

public class FileUppercase
{
    public static void Main()
    {
        using (StreamReader input = new StreamReader("input.txt")) 
        {
            using (StreamWriter output = new StreamWriter("output.txt"))
            {
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
            }
        }
    }
}
