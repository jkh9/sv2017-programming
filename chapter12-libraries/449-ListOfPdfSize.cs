/*
Create a program to create an HTML file containing the list of PDF 
files in the current directory (including size).

For example, if in the current directory there are images called

1.pdf
2.pdf

and their sizes are 398 KB and 130 KB, the result should be


<html>
<body>
<ul>
<li><a href="1.pdf">1.pdf</a> (398 KB)</li>
<li><a href="2.pdf">2.pdf</a> (130 KB)</li>
</ul>
</body>
</html>
*/

//Irene Guijarro Martínez

using System;
using System.IO;
public class htmlPNG
{
    public static void Main()
    {
        StreamWriter file = new StreamWriter("pdfs.html");
        DirectoryInfo dir = new DirectoryInfo(".");
        FileInfo[] files = dir.GetFiles();
        file.WriteLine("<html>");
        file.WriteLine("<body>");
        file.WriteLine("<ul>");

        foreach (FileInfo fichero in files)
        {
            if (fichero.Extension == ".pdf")
            {
                file.WriteLine("    <li><a href=\"" + 
                    fichero.Name + "\">" + 
                    fichero.Name + "</a>" + 
                    " (" + fichero.Length / 1024 + 
                    " KB) </li>");
            }
        }
        file.WriteLine("</ul>");
        file.WriteLine("</body>");
        file.WriteLine("</html>");
        file.Close();
    }
}
