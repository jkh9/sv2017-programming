// Create a C# program to invert the contents of a text file 
// (and dump it to a new file), using a dynamic structure.

// Javier Saorín Vidal
using System.IO;
using System.Collections;

class FileInverter
{
    static void Main(string[] args)
    {
        string[] dataFile = File.ReadAllLines("data.dat");

        ArrayList data = new ArrayList();

        for (int i = 0; i < dataFile.Length; i++)
        {
            data[i] = dataFile[i];
        }

        data.Reverse();

        for (int i = 0; i < data.Count; i++)
        {
            dataFile[i] = (string) data[i];
        }

        File.WriteAllLines("data.dat", dataFile);
    }
}
