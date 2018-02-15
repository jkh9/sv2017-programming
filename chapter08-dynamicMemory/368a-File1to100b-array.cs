/*
Create a text file named "numbers.txt", using File.WriteAllLines 
and an arrayList or List<string>

Write in it 100 lines "Line 1", "Line 2" and so on

Test the resulting file with any text editor
*/

// First approach: using an array

/*
    -------------------
    Miguel Puerta Ramírez
    -------------------
*/
using System.IO;
public class FilesTest
{
    public static void Main()
    {
        string[] numbers = new string[100];

        for (int i = 1; i <= 100; i++)
            numbers[i - 1] = "Line " + i.ToString();

        File.WriteAllLines("numbers.txt", numbers);
    }
}
