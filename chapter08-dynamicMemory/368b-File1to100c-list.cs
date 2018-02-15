/*
Create a text file named "numbers.txt", using File.WriteAllLines 
and an arrayList or List<string>

Write in it 100 lines "Line 1", "Line 2" and so on

Test the resulting file with any text editor
*/

// Second approach, List of strings

/*
    -------------------
    Guillermo Pastor
    -------------------
*/
using System.IO;
using System.Collections.Generic;
public class FilesTest
{
    public static void Main()
    {
        List<string> numeros = new List<string>();

        for (int i = 1; i <= 100; i++)
            numeros.Add(i.ToString());

        File.WriteAllLines("numbers.txt", numeros);
    }
}
