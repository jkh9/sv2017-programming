
//Brandon Blasco, Cesar Martin, Luis Selles

using System;
using System.IO;

public class TxtToHtml4
{
    public static void Main()
    {
        Console.Write("Enter a file name: ");
        string inputFilename = Console.ReadLine();

        if (!File.Exists(inputFilename))
        {
            Console.WriteLine("File not found!");
        }
        else
        {
            try
            {
                StreamReader myTXT = new StreamReader(inputFilename);

                string outputFilename = inputFilename;
                if (outputFilename.EndsWith(".txt"))
                    outputFilename =
                        outputFilename.Substring(0,
                            outputFilename.LastIndexOf('.'))
                        + ".html";
                else
                    outputFilename += ".html";

                StreamWriter myHTML = File.CreateText(outputFilename);
                myHTML.WriteLine("<html>");
                myHTML.WriteLine("    <head>");
                myHTML.WriteLine("    <title>Prolog</title>");
                myHTML.WriteLine("    </head>");
                myHTML.WriteLine("    <body>");
                myHTML.WriteLine("          <center>");
                string line;
                do
                {
                    line = myTXT.ReadLine();
                    if (line != null)
                    {
                        myHTML.WriteLine("Hello World!");
                    }
                } while (line != null);
                myHTML.WriteLine("          </center>");
                myHTML.WriteLine("    </body>");
                myHTML.WriteLine("</html>");

                myHTML.Close();
                myTXT.Close();
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("Path too long");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not accessible");
            }
            catch (IOException e)
            {
                Console.WriteLine("I/O error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Oooops... " + e.Message);
            }
        }
    }
}
