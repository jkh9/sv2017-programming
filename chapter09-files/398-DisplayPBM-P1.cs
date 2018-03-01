using System;
using System.IO;

class DisplayPBM
{
    static void Main(string[] args)
    {
        string fileName;
        string allText = "";
        int width = 0, height = 0;
        
        if (args.Length != 1)
        {
            Console.Write("File name? ");
            fileName = Console.ReadLine();
        }
        else
        {
            fileName = args[0];
        }
        
        if (!File.Exists(fileName))
        {
            Console.WriteLine("File not found");
        }
        else
            try
            {
                StreamReader input = new StreamReader(fileName);
                string firstLine = input.ReadLine();
                if( firstLine != "P1")
                {
                    Console.WriteLine("File not valid");
                }
                else
                {
                    string secondLine = input.ReadLine();
                    if (secondLine.StartsWith("#"))  // Comment?
                    {
                        secondLine = input.ReadLine();
                    }
                    
                    // Width and height
                    width = Convert.ToInt32(secondLine.Split()[0]);
                    height = Convert.ToInt32(secondLine.Split()[1]);
                    Console.WriteLine("Width: "+width);
                    Console.WriteLine("Height: "+height);

                    // Image data
                    string line = input.ReadLine();
                    
                    while( line != null )
                    {
                        allText += line;
                        line = input.ReadLine();
                    }
                }
                input.Close();
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("Path too long");
            }
            catch (IOException e)
            {
                Console.WriteLine("I/O exception: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

        // Finally, let's display the image
        allText = allText.Replace(" ", "");
        for( int i = 0; i < allText.Length; i++)
        {
            Console.Write(allText[i]=='1'? "#" : ".");
            if (i % width == width-1)
            {
                Console.WriteLine();
            }
        }
    }
}

