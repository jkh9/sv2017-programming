using System;
using System.Collections.Generic;
using System.IO;

class ModulaTutorialConverterV1
{
    static void Main(string[] args)
    {
        string[] originalFile = File.ReadAllLines("modula.txt");
        List<string> result = new List<string>(originalFile);
        StreamWriter output = new StreamWriter("modula.html");

        output.WriteLine("<html><body>");

        for (int i = 1; i < result.Count; i++)
            output.WriteLine("<pre>" + result[i] + "</pre>");

        output.WriteLine("</body></html>");
        output.Close();

    }
}
