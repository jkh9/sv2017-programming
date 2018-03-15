//Javier Herreros ,Luis Martin-Montalvo,Miguel Pastor,Lucia Navarro
using System;
using System.IO;

public class linuxconverter
{
    public static void Main(string[] args)
    {
        string fileName;
        int count = 0;

        if (args.Length > 0)
        {
            fileName = args[0];
        }
        else
        {
            Console.Write("Noimbre del fichero?");
            fileName = Console.ReadLine();
        }

        if (!File.Exists(fileName))
        {
            Console.WriteLine("el fichero {0}", fileName +"No disponible");
        }
        else
        {
            try
            {
                string file = fileName;

                StreamReader reader = File.OpenText(fileName);
                StreamWriter writer = File.CreateText(file);
                string line;

                line = reader.ReadLine();
                writer.WriteLine("<html>");
                writer.WriteLine("<head>");
                writer.WriteLine("<meta charset-utf8>");
                writer.WriteLine("<meta name=\"viewport\" content=\"width = device - width, initial - scale = 1.0\" />");
                writer.WriteLine("</head>");
                writer.WriteLine("<body>");

                do
                {
                    if (line != null)
                    {
                        if (count > 0 && !line.Trim().StartsWith("- "))
                        {
                            writer.WriteLine("</li>");
                            writer.WriteLine("</ul>");
                            count = 0;
                        }
                        else if (line.Trim().StartsWith("--"))
                        {
                            writer.WriteLine("<h1>");
                            writer.WriteLine(line);
                            writer.WriteLine("</h1>");
                        }
                        else if (line.Trim().StartsWith("- "))
                        {
                            if (count > 0)
                            {
                                writer.WriteLine("<li>");
                                writer.WriteLine(line);
                                writer.WriteLine("</li>");
                            }
                            else
                            {
                                writer.WriteLine("<ul>");
                                writer.WriteLine("<li>");
                                writer.WriteLine(line);
                                writer.WriteLine("</li>");
                            }
                         
                            count++;
                        }
                        else if (line.Trim().StartsWith("<p>"))
                        {
                            Console.WriteLine("Ya he terminado");
                            if (line.Trim().StartsWith("</p>"))
                            {
                                //To Do
                            }
                        }
                        else
                        {
                            //To Do
                        }
                    }

                } while (line != null);

                writer.WriteLine("</body>");
                writer.WriteLine("</html>");

                reader.Close();
                writer.Close();
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("Entered path was too long");
                return;
            }
            catch (IOException exp)
            {
                Console.WriteLine("Input/output error: {0}", exp.Message);
                return;
            }
            catch (Exception exp)
            {
                Console.WriteLine("Unexpected error: {0}", exp.Message);
                return;
            }
        }
    }
}
