/*
insert into personas (nombre, direccion, edad) values ('smith, pedro', 'su calle', 23);
insert into personas (nombre, direccion, edad) values ('juan', 'calle cinco, 6', 24);
insert into ciudades (codigo, nombre) values ('a', 'alicante');

--->

personas
nombre: smith, pedro
direccion: su calle
edad: 23

personas
nombre: juan
direccion: calle cinco, 6
edad: 24

ciudades
codigo: a
nombre: alicante
*/

// SQL Extractor, first approach

using System;
using System.IO;

class SQLextractor
{
    static void Main()
    {
        StreamReader inFile;
        StreamWriter outFile;
        string line;

        Console.Write("Enter file name: ");
        string fileName = Console.ReadLine();

        if(!File.Exists(fileName))
        {
            Console.WriteLine("File not found!");
            return;
        }
        
        try
        {
            inFile = File.OpenText(fileName);
            outFile = File.CreateText(fileName+".out.txt");
            do
            {
                line = inFile.ReadLine();
                if (line != null)
                    ExtractAndDump(line, outFile);
            } while(line != null);
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
            Console.WriteLine("Input/output error: {0}", exp.Message);
            return;
        }
        catch (Exception exp)
        {
            Console.WriteLine("Unexpected error: {0}", exp.Message);
            return;
        }
        Console.WriteLine("Extraction finished");
               
    }
    
    private static void ExtractAndDump(string line, StreamWriter file)
    {
        if (! line.Contains("insert"))
            return;
            
        // Remove leading part
        line = line.Replace("insert into ", "");
        
        // Extract name
        int nameEndPos = line.IndexOf(" ");
        string name = line.Substring(0, nameEndPos);
        file.WriteLine(name);
        
        // Extract field names
        line = line.Substring(nameEndPos+2);
        int fieldsEndPos = line.IndexOf(")");
        string allFields = line.Substring(0, fieldsEndPos);
        
        // And extract values
        line = line.Substring(fieldsEndPos+10);  // ) values (
        line = line.Remove(line.Length-2);  // );
        string values = line;
                
        // Split field names
        // Now they are something like "codigo, nombre"
        allFields = allFields.Replace(" ", "");
        string[] fieldNames = allFields.Split(',');
        
        // Split values
        // Now they are something like "'a', 'alicante'"
        // This will fail if there are intermediate commas
        string[] fieldValues = values.Split(',');
        // And let's remove leading and trailing quotes
        for (int i=0; i<fieldValues.Length; i++)
        {
            fieldValues[i] = fieldValues[i].Trim();  // extra spaces
            if (fieldValues[i].StartsWith("\'"))  // leading quotes
                fieldValues[i] = fieldValues[i].Substring(1);
            if (fieldValues[i].EndsWith("\'"))  // trailing quotes
                fieldValues[i] = fieldValues[i].Remove(
                    fieldValues[i].Length-1);
        }
        
        // And display all of them
        for (int i=0; i<fieldNames.Length; i++)
            file.WriteLine(fieldNames[i] + ": "+fieldValues[i]);
        
        // Separation blank line
        file.WriteLine();
    }
}

