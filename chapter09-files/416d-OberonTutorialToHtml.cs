// Gonzalo Martinez, Victor Tébar, Miguel Garcia

using System;
using System.Collections.Generic;
using System.IO;

class OberguidToHTML
{
    public static void Main()
    {
        string inputFileName = "OBERGUID.txt";

        if (!File.Exists(inputFileName))
        {
            Console.WriteLine("File doesn't exist!");
        }
        else
        {
            try
            {
                string[] data = File.ReadAllLines(inputFileName);

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
                myHTML.WriteLine("<head>");
                myHTML.WriteLine("<style>");
                myHTML.WriteLine("body{ background-color: #edf3ff;" +
                    "font-family: Arial;}");
                myHTML.WriteLine("</style>");
                myHTML.WriteLine("</head>");
                myHTML.WriteLine("<body>");
                List<string> lines = new List<string>();

                string line;
                bool startedList = false;
                int voidLineCount = 0;
                myHTML.WriteLine("<h1>" + data[1] + "</h1>");
                myHTML.WriteLine("<h2>" + data[3] + "</h2>");
                myHTML.WriteLine("<h2>" + data[5] + "</h2>");
                for (int i = 6; i < data.Length; i++)
                {
                    line = data[i];

                    if (line != null)
                    {
                        if (line != "")
                        {

                            if(voidLineCount >= 2)
                            {
                                myHTML.Write("<h3>" + line + "</h3>");
                            }
                            
                            else if(data[i].StartsWith("  "))
                            {
                                if(lines.Count > 0)
                                {
                                    startedList = true;
                                    myHTML.WriteLine("<h3>" + lines[0] + "</h3>");
                                    lines.Clear();
                                    myHTML.WriteLine("<ul>");
                                }
                                myHTML.WriteLine("<li>" + line + "</li>");
                                                               
                            }
                            else
                            {
                                lines.Add(line.Trim());
                            }
                            voidLineCount = 0;
                        }
                        else
                        {
                            if (startedList)
                            {
                                myHTML.WriteLine("</ul>");
                                startedList = false;
                            }
                            else
                            {
                                myHTML.Write("<p>");
                                foreach (string s in lines)
                                {
                                    myHTML.WriteLine(s);
                                }
                                myHTML.Write("</p>");
                                lines.Clear();
                            }
                            voidLineCount++;
                        }
                    }
                }

                myHTML.WriteLine("</body>");
                myHTML.WriteLine("</html>");

                myHTML.Close();
            }
            catch (FileNotFoundException)
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
