using System;
using System.Collections.Generic;
using System.IO;

class ModulaTutorialConverterV3
{
    static void Main(string[] args)
    {
        if (!File.Exists("modula.txt"))
        {
            Console.WriteLine("File not found!");
            return;
        }
        
        List<string> result;
        
        try
        {
            string[] originalFile = File.ReadAllLines("modula.txt");
            result = new List<string>(originalFile);
        }
        catch (IOException)
        {
            Console.WriteLine("Read error");
            return;
        }
        catch (Exception e)
        {
            Console.WriteLine("Unexpected error: "+e.Message);
            return;
        }

        // Let's remove the page jumps (0xFF)
        for (int i = 1; i < result.Count; i++)
            if (result[i].Length > 4)
                if (result[i][0] == 0xFF)
                {
                    result.RemoveAt(i);
                    i--;
                }

        // Let's remove the page numbers
        for (int i = 1; i < result.Count; i++)
            if (result[i].Contains("         Page"))
            {
                int spacesPos = result[i].IndexOf("       ");
                result[i] = result[i].Remove(spacesPos);
            }

        // Let's create titles (duplicated lines)
        for (int i = 1; i < result.Count; i++)
            if (result[i].Trim() == result[i - 1].Trim())
            {
                result[i - 1] = "<h2>" + result[i - 1] + "</h2>";
                result.RemoveAt(i);
                i--;
            }

        // And subtitles (such as 7.1.3, after the index)
        for (int i = 140 /* !!! */; i < result.Count - 1; i++)
            if (result[i].Trim().Length > 4)
                if ((result[i].Trim()[0] >= '0') &&
                    (result[i].Trim()[0] <= '9') &&
                    (result[i].Trim()[1] == '.') &&
                    (result[i].Trim()[2] >= '0') &&
                    (result[i].Trim()[2] <= '9'))
                {
                    result[i] = "<h3>" + result[i] + "</h3>";
                }

        // And next level of subtitles (lines with ___)
        for (int i = 1; i < result.Count-1; i++)
            if (result[i].Trim().Length > 4)
                if (result[i].Trim().Substring(0,3) == "___")
                {
                    result[i + 1] = "<h4>" + result[i + 1] + "</h4>";
                    result.RemoveAt(i);
                    i--;
                }

        // All paragraphs (column 12 to 72)
        for (int i = 140; i < result.Count-1; i++)
            if ((result[i].Length == 72) &&
                    result[i].StartsWith("        ") &&
                    (result[i-1].Trim().Length == 0))
                {
                    result[i-1] = "<p>";
                    while( result[i].Length  == 72)
                    {
                        result[i] = result[i].Trim();
                        i++;
                    }
                    result[i] = result[i].Trim() + "</p>";
                }
                
        // And finally let's dump the result
        
        try
        {
            StreamWriter output = new StreamWriter("modula.html");
            output.WriteLine("<html><body>");

            for (int i = 1; i < result.Count; i++)
                if ((result[i].Length > 0) 
                        && (result[i][0] == '<'))  // If it already contains a tag
                    output.WriteLine(result[i]);
                else  if ((result[i].Length > 0)   // It it is a paragraph
                        && (result[i][0] != ' '))
                    output.WriteLine(result[i]);
                else  // Otherwise, as preformatted
                    output.WriteLine("<pre>" + result[i] + "</pre>");

            output.WriteLine("</body></html>");
            output.Close();
        }
        catch (IOException)
        {
            Console.WriteLine("Write error");
        }
        catch (Exception e)
        {
            Console.WriteLine("Unexpected error: "+e.Message);
        }

    }
}
