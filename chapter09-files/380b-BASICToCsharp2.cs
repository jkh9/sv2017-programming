// Create a program to read a simple BASIC source file like 
// the following one and convert it to C#:
// 
// 10 PRINT "Enter a number"
// 20 INPUT n1
// 30 PRINT "Enter another number"
// 40 INPUT secondNumber
// 50 PRINT "Their sum is"
// 60 PRINT n1+secondNumber

//Raul Gogna

using System;
using System.IO;

class Ex380
{
    public static void Main()
    {
        Console.Write("Enter file name: ");
        string inputFile = Console.ReadLine();
        if(!File.Exists(inputFile))
            Console.WriteLine("File does not exist");
        else
        {
            try
            {
                StreamReader reader = new StreamReader(inputFile);

                StreamWriter writer = File.CreateText(inputFile + ".cs");
                writer.WriteLine("//Raul Gogna");
                writer.WriteLine("using System;");
                writer.WriteLine("class Ex380");
                writer.WriteLine("{");
                writer.WriteLine("    public static void Main()");
                writer.WriteLine("    {");
                string line;
                do
                {
                    line = reader.ReadLine();
                    if(line != null)
                    {
                        line = line.Remove(0, line.IndexOf(" ") + 1);
                        if (line.Contains("PRINT"))
                        {
                            writer.Write("        ");
                            writer.WriteLine("Console.WriteLine(" + 
                                line.Substring(6) + ");");
                        }
                        if(line.Contains("INPUT"))
                        {
                            writer.Write("        ");
                            writer.WriteLine("int " + line.Substring(6) + 
                                " = Convert.ToInt32(Console.ReadLine());");
                        }
                    }
                } while (line != null);
                writer.WriteLine("    }");
                writer.WriteLine("}");
                writer.Close();
                reader.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine("I/O error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}
