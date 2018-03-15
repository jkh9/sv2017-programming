using System;
using System.Collections.Generic;
using System.IO;

class ModulaTutorialConverterV2
{
    static void Main(string[] args)
    {
        if (!File.Exists("modula.txt"))
        {
            Console.WriteLine("File not found!");
            return;
        }

        string[] originalFile = File.ReadAllLines("modula.txt");
        List<string> result = new List<string>(originalFile);
        StreamWriter output = new StreamWriter("modula.html");

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

        // And subtitles (lines with ___)
        for (int i = 1; i < result.Count-1; i++)
            if (result[i].Trim().Length > 4)
                if (result[i].Trim().Substring(0,3) == "___")
                {
                    result[i + 1] = "<h3>" + result[i + 1] + "</h3>";
                    result.RemoveAt(i);
                    i--;
                }

        // And finally let's dump the result
        output.WriteLine("<html><body>");

        for (int i = 1; i < result.Count; i++)
        {
            if ((result[i].Length > 0) 
                    && (result[i][0] == '<'))  // If it already contains a tag
                output.WriteLine(result[i]);
            else  // Otherwise, as preformatted
                output.WriteLine("<pre>" + result[i] + "</pre>");
        }

        output.WriteLine("</body></html>");
        output.Close();

    }
}
