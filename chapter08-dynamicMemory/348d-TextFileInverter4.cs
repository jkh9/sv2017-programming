// Create a C# program to invert the contents of a text file 
// (and dump it to a new file), using a dynamic structure.

//Almudena Loppez Sanchez
using System.Collections;
using System.IO;

public class Ex346
{
    public static void Main()
    {
        string[] lines = File.ReadAllLines("data1.txt");

        Stack s = new Stack(lines);

        int size = s.Count;
        string[] texto = new string[size];

        for(int i = 0; i < size; i++)
        {
            texto[i] = (string)s.Pop();
        }

        File.WriteAllLines("data2.txt", texto);
    }
}
