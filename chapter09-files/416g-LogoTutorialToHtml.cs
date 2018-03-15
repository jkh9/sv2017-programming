// Javier Saorín Vidal, Querubin Santana, Raul Gogna
using System.IO;


class LogoToHtml
{
    static void Main(string[] args)
    {
        StreamWriter output = new StreamWriter("LOGO.html");
        output.WriteLine("<html>");
        output.WriteLine("<body>");

        string[] lines = File.ReadAllLines("LOGO.txt");
        bool pOpen = false;
        for (int i = 0; i < lines.Length; i++)
        {
            if (i == 26)
            {
                output.WriteLine("<h1>" + lines[i] + "</h1>");
                output.WriteLine("<ul>");

                i += 2;
                while (i < 35)
                {
                    i++;
                    output.WriteLine("<li>" + lines[i] + "</li>");
                }
                output.WriteLine("</ul>");

            }
            else if (lines[i].StartsWith("_"))
            {
                output.WriteLine("<h1>");
                while (i < lines.Length || lines[i].StartsWith("_"))
                {
                    i++;
                    output.WriteLine(lines[i]);
                }
                output.WriteLine("</h1>");
                i++;
            }
            else if (lines[i].Trim() == "")
            {
                output.WriteLine("<p>");
                while (i < lines.Length || lines[i].StartsWith("_") || 
                    lines[i].Trim() == "" ||
                    (lines[i].StartsWith("..") && lines.Length < 6))
                {
                    i++;
                    output.WriteLine(lines[i]);
                }
                output.WriteLine("</p>");
                i++;
            }
            else
            {

            }
        }
    }
}
