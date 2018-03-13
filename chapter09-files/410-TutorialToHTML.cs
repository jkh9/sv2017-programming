// Ex.410: Converting a tutorial to HTML, preliminary version
// Gonzalo Martinez, Victor Tébar, Miguel Garcia

using System;
using System.Collections.Generic;
using System.IO;

public class Ex410
{
    public static void Main()
    {
        Console.Write("File name? ");
        string inputFileName = Console.ReadLine();
        
        if(!File.Exists(inputFileName))
        {
            Console.WriteLine("File doesn't exist!");
        }
        else
        {
            try
            {
                StreamReader myTXT = new StreamReader(inputFileName);

                string outputFilename = inputFileName;
                if (outputFilename.EndsWith(".txt"))
                    outputFilename =
                        inputFileName.Substring(0,
                            inputFileName.LastIndexOf('.'))
                        + ".html";
                else
                    outputFilename += ".html";

                StreamWriter myHTML = File.CreateText(outputFilename);
                myHTML.WriteLine("<html>");
                myHTML.WriteLine("<body>");
                List<string> lines = new List<string>();

                string line;
                do
                {
                    line = myTXT.ReadLine();
                    if (line != null)
                    {
                        if(line != "\n")
                        {
                            lines.Add(line.Trim());
                        }

                        myHTML.WriteLine("<p>" + line + "</p>");
                    }
                } while (line != null);

                myHTML.WriteLine("</body>");
                myHTML.WriteLine("</html>");

                myHTML.Close();
                myTXT.Close();
            }
            catch(FileNotFoundException)
            {
                Console.WriteLine("File not found");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("Path too long");
            }
            catch (IOException e)
            {
                Console.WriteLine("IO Error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
