/*
Exam of 2012-2013: C# to Python

1.- Crea un conversor básico de C# a Python. Debe partir de un fuente como

using System;
public class DivideTwoNumbers
{
    public static void Main()
    {
        int number1, number2;
        
        Console.Write("Enter the first number:");
        number1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the second number:");
        number2 = Convert.ToInt32(Console.ReadLine());
        
        if (number2 != 0)
        {
            Console.WriteLine("The result for {0} / {1} is {2}", number1, number2, number1/number2);
        }
        else
            Console.WriteLine("Cannot be divided");
        for (int i=1; i<4; i++)
            Console.WriteLine("Bye!"); 
    }
}


y convertirlo en algo como:

 
print("Enter the first number:")
number1 = int(input())
print("Enter the second number:")
number2 = int(input())
if number2 != 0:
        print("The result for {0} / {1} is {2}".format(number1, number2, number1/number2))
else:
        print("Cannot be divided")
for i in range (1,4):
    print("Bye!")


El nombre del fichero a analizar se le debe preguntar al usuario.
*/

//Pedro Luis Coloma
using System;
using System.IO;

class CSharpToPython
{
    static void Main()
    {
        StreamReader inFile;
        StreamWriter outFile;
        string line;

        Console.Write("Enter file name: ");
        string fileName = Console.ReadLine();

        if (!File.Exists(fileName))
        {
            Console.WriteLine("File not found!");
            return;
        }

        try
        {
            inFile = File.OpenText(fileName);
            outFile = File.CreateText(fileName + ".py");
            do
            {
                line = inFile.ReadLine();
                if (line != null)
                    ExtractAndDump(line, outFile);
            } while (line != null);
            inFile.Close();
            outFile.Close();
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("Entered path was too long");
            return;
        }
        catch (IOException exp)
        {
            Console.WriteLine("Input/output error: "+ exp.Message);
            return;
        }
        catch (Exception exp)
        {
            Console.WriteLine("Unexpected error: "+ exp.Message);
            return;
        }
        Console.WriteLine("Extraction finished");
    }

    private static void ExtractAndDump(string line, StreamWriter file)
    {
        if (line.Contains("public") || line.Contains("{") || line.Contains("}")
            || line.Contains("int number1, number2;"))
            return;


        line = line.Replace("Console.Write", "print");
        line = line.Replace(";", "");
        line = line.Replace("Convert.ToInt32(Console.ReadLine())", "int(input())");
        line = line.Replace(";", "");

        if (line.Contains("if"))
        {
            line = line.Replace("(", "");
            line = line.Replace(")", ":");
        }
        if (line.Contains("else"))
        {
            line = line.Replace("else", "else:");
        }
        //for i in range(1, 4):         for (int i = 1; i < 4; i++)
        if (line.Contains("\","))
        {
            line = line.Replace("\",", ".format(");
            line = line.Insert(line.Length, ")");
        }
        file.WriteLine(line);
    }
}
