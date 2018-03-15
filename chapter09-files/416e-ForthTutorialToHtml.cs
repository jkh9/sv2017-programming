//Guillermo Pastor Pastor, Daniel Miquel, Javier Cases, Pedro Coloma
using System;
using System.IO;

class Ex
{
    static void Main(string[] args)
    {
        StreamReader myTXT = new StreamReader("ref-forth-gil.txt");

        string outputFilename = "ref-forth-gil.txt.html";

        StreamWriter myHTML = File.CreateText(outputFilename);
        myHTML.WriteLine("<html>");
        myHTML.WriteLine("<body>");
        bool endP = false;
        string line;
        string lines = "";
        do
        {
            line = myTXT.ReadLine();
            if (line != null)
            {
                lines += line.Trim();
                if (line == "")
                {
                    endP = true;
                    if (endP)
                    {
                        if (lines.Contains("=="))
                            myHTML.Write("<h1>" + line + "</h1>");
                        endP = false;
                        myHTML.WriteLine("<p>" + lines + "</p>");
                    }
                    lines = "";
                }
            }
        } while (line != null);

        myHTML.WriteLine("</body>");
        myHTML.WriteLine("</html>");

        myTXT.Close();
        myHTML.Close();
    }
}
