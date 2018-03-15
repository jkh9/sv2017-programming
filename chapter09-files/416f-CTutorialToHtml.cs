//Almudena Lopez Sanchez
//Angel Rebollo Berná

using System;
using System.Collections.Generic;
using System.IO;

public class Ctotml
{
    public static void Main()
    {
       
        try
        {
            StreamReader input = new StreamReader("CINTRO.TXT");
            StreamWriter output = File.CreateText("cintroHTML.html");
            output.WriteLine("<html>");
            output.WriteLine("<body>");
            List<string> lines = new List<string>();

            
            string line;
            int count = 0;
            do
            {
                line = input.ReadLine();
                if (line != null)
                {
                    if (line != "\n")
                    {
                        if(!line.Contains("Intro to DDS MICRO-C "))
                        {
                            lines.Add(line.Trim());
                            count++;
                        }
                    }
                    else
                    {
                        output.WriteLine("<br>");
                        if(count != 0)
                        {
                            output.Write("<p>");
                            output.Write(lines);
                            output.Write("</p>");
                            //lines.Remove();
                            count = 0;
                        }

                    }
                }
            } while (line != null);


            output.WriteLine("</body>");
            output.WriteLine("</html>");

            output.Close();
            input.Close();
        }
        catch (IOException e)
        {
            Console.WriteLine("I/O ERROR: " + e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("ERROR: " + e.Message);
        }
    }
}
