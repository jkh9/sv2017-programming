//Moisés Encinas Picazo, Jose Vilaplana, Marcos Cervantes

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

public class Ex416
{
    public static void Main()
    {
        Console.Write("File name? ");
        string inputFileName = "LISPTUT.txt";

        if (!File.Exists(inputFileName))
        {
            Console.WriteLine("File doesn't exist!");
        }
        else
        {
            try
            {
                List<string> lines = new List<string>();
                StreamReader myTXT = new StreamReader(inputFileName);

                string outputFilename = inputFileName;
                if (outputFilename.EndsWith(".txt"))
                    outputFilename =
                        inputFileName.Substring(0,
                            inputFileName.LastIndexOf('.'))
                        + ".html";
                else
                    outputFilename += ".html";

                string line;
                do
                {
                    line = myTXT.ReadLine();
                    if (line != null)
                    {
                        if (line == "")
                        {
                            lines.Add("</br>");
                        }
                        else
                        {
                            lines.Add("<pre>");
                            lines.Add(line);
                            do
                            {
                                line = myTXT.ReadLine();
                                if (line != "")
                                {
                                    lines.Add(line);
                                }
                            } while (line != "");
                            lines.Add("</pre>");
                        }
                    }
                } while (line != null);
                myTXT.Close();


                StreamWriter myHTML = File.CreateText(outputFilename);
                myHTML.WriteLine("<html>");
                myHTML.WriteLine("<body>");
                for (int i = 0; i < lines.Count; i++)
                {
                    if (lines[i] != "")
                    {
                        if (lines[i] != "<pre>" && lines[i] != "</pre>" && lines[i] != "</br>")
                        {
                            lines[i] = lines[i].Replace("<", "&lt;");
                            lines[i] = lines[i].Replace(">", "&gt;");
                        }
                        myHTML.WriteLine(lines[i]);
                    }
                    else
                    {
                        myHTML.WriteLine();
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
