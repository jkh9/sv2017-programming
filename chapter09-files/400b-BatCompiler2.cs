using System;
using System.IO;
using System.Text;

public class Ejer400{
    public static void WriteHeader(StreamWriter w){
        w.WriteLine("using System;");
        w.WriteLine("using System.IO;");
        w.WriteLine("using System.Diagnostics;");
        w.WriteLine("class FicheroBat {");
        w.WriteLine("    public static void Main(string[] args) {");
        w.WriteLine("        Process proc;");
    }
    
    public static void TranslateLine(string str,StreamWriter w){
        string[] parts = str.Trim().Split();
        string inside = "";
        switch(parts[0].ToLower()){
            case "echo":
                inside = str.Substring(4).Trim();
                w.WriteLine("        System.Console.WriteLine(\"" + inside 
                    + "\");");
                break;
            case "cls":
                w.WriteLine("        System.Console.Clear();");
                break;
                
            case "cd":
                inside = str.Substring(2).Trim();
                w.WriteLine("        Directory.SetCurrentDirectory(\"" + 
                    inside + "\");");
                break;
                
            default:
                w.WriteLine("        proc = Process.Start(\"" + str + "\"); " + 
                    "proc.WaitForExit();");
                break;
        }
    }
    
    public static void Main(){
        Console.Write("File name?");
        string fileName = Console.ReadLine();
        if(!File.Exists(fileName)){
            Console.WriteLine("That file doesnt exists");
        }
        else{
            try{
                StreamReader readFile = new StreamReader(fileName);
                StreamWriter writeFile = 
                    new StreamWriter(fileName + ".cs");
                
                WriteHeader(writeFile);
                
                string line = readFile.ReadLine();
                while(line != null){
                    TranslateLine(line,writeFile);
                    line = readFile.ReadLine();
                }
                
                writeFile.WriteLine("    }");
                writeFile.WriteLine("}");
                
                writeFile.Close();
                readFile.Close();
                
            }
            catch(PathTooLongException){
                Console.WriteLine("The path is too long");
            }
            catch(IOException e){
                Console.WriteLine("I/O error: " + e);
            }
            catch(Exception e){
                Console.WriteLine("Error: " + e);
            }
        }
    }
}

