/*
Create a text file named "numbers.txt", using the constructor of StreamWriter

Write in it 100 lines "Line 1", "Line 2" and so on

Check the resulting file with any text editor


    -------------------
    Javier Saorín Vidal
    -------------------
*/
using System.IO;

public class FilesTest
{
    public static void Main()
    {
        StreamWriter myFile = new StreamWriter("numbers.txt");

        for (int i = 1; i <= 100; i++)
            myFile.WriteLine("Line "+i);

        myFile.Close();
    }
}
