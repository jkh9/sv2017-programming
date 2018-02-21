/*
Create a "Text to HTML converter", which will read a source text file and 
create a HTML file from its contents. For example, if the file contains:

Hola
Soy yo
Ya he terminado

The resulting HTML file should contain

<html>
<body>
<p>Hola</p>
<p>Soy yo</p>
<p>Ya he terminado</p>
</body>
</html>

The name of the destination file must be the same as the source file, but with 
".html" extension (which will replace the original ".txt" extension, if it 
exists).  You must check errors properly.
*/

// Version 1: Processing the data, not checking errors

// Jose Vilaplana

using System;
using System.IO;

public class TxtToHtml1
{
    public static void Main()
    {
        Console.Write("Enter a file name: ");
        string inputFilename = Console.ReadLine();

        StreamReader myTXT = new StreamReader(inputFilename);
        
        string outputFilename = inputFilename + ".html";
        
        StreamWriter myHTML = File.CreateText(outputFilename);
        myHTML.WriteLine("<html>");
        myHTML.WriteLine("<body>");

        string line;
        do
        {
            line = myTXT.ReadLine();
            if (line != null)
            {
                myHTML.WriteLine("<p>" + line + "</p>");
            }
        } while (line != null);
        
        myHTML.WriteLine("</body>");
        myHTML.WriteLine("</html>");

        myTXT.Close();
        myHTML.Close();
    }
}
