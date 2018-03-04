/*
Crea un traductor básico de "fichero BAT de MsDos" (lote de órdenes del 
sistema operativo) a "fuente de C#" (bat2cs.exe), que preguntará al 
usuario el nombre del fichero a convertir y realizará las siguientes 
conversiones:

- Cada orden "cls" deberá convertirse en un "System.Console.Clear()"

- Cada orden "echo" deberá cambiarse por un "System.Console.WriteLine"

- Cada orden "cd" pasará a ser un " Directory.SetCurrentDirectory"

- Las demás órdenes deberán incluirse en un "Process.Start" seguido de 
  un "WaitForExit" (ver ejemplo).

Como prueba del traductor, se debe traducir un fichero BAT formado 
por las siguientes líneas:

CLS
echo Mirando lista de directorio superior
Cd ..
dir > lista.txt
NOTEPAD lista.txt
Echo Ordenes permitidas: CLS, ECHO, CD

El fuente resultante en C# debería compilar correctamente, y ser 
similar a éste:

using System;
using System.IO;
using System.Diagnostics;
class FicheroBat 
{
  public static void Main() 
  {
    Process proc;
    System.Console.Clear();
    System.Console.WriteLine("Mirando lista de directorio superior");
    Directory.SetCurrentDirectory("..");
    proc = Process.Start("dir > lista.txt"); proc.WaitForExit();
    proc = Process.Start("NOTEPAD lista.txt"); proc.WaitForExit();
    System.Console.WriteLine("Ordenes permitidas: CLS, ECHO, CD");
  }
}
*/
using System;
using System.IO;

public class BatCompiler
{
    public static void Main (string [] args) 
    {
        string name;
        string line;
        
        if(args.Length == 0) 
        {
            Console.Write("Enter the file name: ");
            name = Console.ReadLine();
        }
        else 
        {
            name = args[0];
        }
        if(!File.Exists (name)) 
        {
            Console.WriteLine("File not found");
        }
        else 
        {
            try
            {
                StreamReader input = File.OpenText(name);
                StreamWriter output = File.CreateText(name+".cs");
                output.WriteLine("using System;");
                output.WriteLine("using System.IO;");
                output.WriteLine("using System.Diagnostics;");
                output.WriteLine();
                output.WriteLine("public class FicheroBat");
                output.WriteLine("{");
                output.WriteLine("    public static void Main()");
                output.WriteLine("    {");
                output.WriteLine("        Process proc;");
                
                do 
                {
                    line = input.ReadLine();
                    if(line != null) 
                    {
                        if(line.ToUpper().Trim() == "CLS") 
                        {
                            output.WriteLine("        Console.Clear();");
                        }
                        
                        else if(line.Trim().ToUpper().StartsWith("ECHO ")) 
                        {
                            string text = line.Trim().Substring(5).TrimStart();
                            output.WriteLine("        Console.WriteLine(\""
                                +text+"\");");
                        }
                        
                        else if(line.Trim().ToUpper().StartsWith("CD ")) 
                        {
                            string text = line.Trim().Substring(3);
                            output.WriteLine("        Directory.SetCurrentDirectory(\""
                                +text+"\");");
                        }
                        else 
                        {
                            output.WriteLine("        proc = Process.Start(\"" 
                                + line + "\"); proc.WaitForExit();");
                        }
                        
                    }
                } 
                while(line != null);
                output.WriteLine("    }");
                output.WriteLine("}");
                input.Close();
                output.Close();
                Console.Write("Finished.");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("Path too long");
            }
            catch (IOException ex)
            {
                Console.WriteLine("Input/output error: {0}", ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected error: {0}", ex.Message);
            }
        }
    }
}
