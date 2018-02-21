// Create a program to read a simple BASIC source file like 
// the following one and convert it to C#:
// 
// 10 PRINT "Enter a number"
// 20 INPUT n1
// 30 PRINT "Enter another number"
// 40 INPUT secondNumber
// 50 PRINT "Their sum is"
// 60 PRINT n1+secondNumber

//Almudena Lopez Sanchez
//Feb 21st c (Ex.380)- Simple BASIC to C#

using System;
using System.IO;

public class BASICToCsharp
{
    public unsafe static void Main()
    {
        Console.WriteLine("Enter a BASIC file: ");
        string file = Console.ReadLine();

        if (!File.Exists(file))
            Console.WriteLine("File not exists...");
        else
        {
            try
            {
                StreamReader sr = new StreamReader(file);
                string newFile = file;
                if (!file.Contains("."))
                    newFile += ".cs";
                else
                {
                    newFile = newFile.Substring(0,
                        newFile.LastIndexOf('.')) + ".cs";
                }

                StreamWriter sw = new StreamWriter(newFile);
                string line;
                sw.WriteLine("//almu.chan");
                sw.WriteLine("using System;");
                sw.WriteLine("public class Program");
                sw.WriteLine("{");
                sw.WriteLine("    public static void Main()");
                sw.WriteLine("    {");
                do
                {
                    line = sr.ReadLine();
                    
                    if (line != null)
                    {
                        line = line.Remove(0, line.IndexOf(" ") + 1);

                        if (line.StartsWith("PRINT"))
                        {
                            line = "        Console.WriteLine(" +
                                line.Substring(6) + 
                                ");";
                        }

                        else if (line.StartsWith("INPUT"))
                        {
                            line = "        int " +
                                line.Substring(6) + 
                                " = Convert.ToInt32(Console.ReadLine());";
                        }
                        sw.WriteLine(line);
                    }
                }
                while (line != null);

                sr.Close();
                sw.WriteLine("    }");
                sw.WriteLine("}");
                sw.Close();
            }
            catch(IOException e)
            {
                Console.WriteLine("I/O error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: " + e.Message);
            }
        }
        
    }
}

