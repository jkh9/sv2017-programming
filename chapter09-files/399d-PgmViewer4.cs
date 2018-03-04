// PGM Viewer
// Version 4: StreamReader + BinaryReader

using System;
using System.IO;

public class PgmViewer 
{ 
    
    public static int Main(string[] args ) 
    {
        if (args.Length != 1)
        {
            Console.WriteLine("You must specify the name of the file as a parameter");
            Console.WriteLine("Example: pgmViewer.exe fileName.pgm");
            return 1;
        }

        string fileName = args[0];
        if (! File.Exists(fileName))
        {
            Console.WriteLine("File not found");
            return 2;
        }
        
        try
        {
            // Headers reading as text
            StreamReader file = new StreamReader(fileName);
            string format = file.ReadLine();
            string sizeAsString = file.ReadLine();
            string shades = file.ReadLine();
            file.Close();
            
            int headerSize = 3 // P5 + newLine
                + sizeAsString.Length + 1 // Size + newLine
                + 4; // 255 + newLine
                        
            // Header 1: P5
            if (format != "P5")
            {
                Console.WriteLine("Not a P5 PGM file");
                return 3;
            }
           
            // Header 2: size
            string[] widthAndHeight = sizeAsString.Split(' ');
            int width = Convert.ToInt32(widthAndHeight[0]);
            int height = Convert.ToInt32(widthAndHeight[1]);
            Console.WriteLine("Size: {0} x {1}", width, height);
            
            // Header 3: Shades of grey -> Skipped
            if (shades != "255")
            {
                Console.WriteLine("Not a 255 levels of grey P5 PGM file");
                return 3;
            }
            
            // And data
            BinaryReader fileB = new BinaryReader(File.Open(fileName, FileMode.Open));
            fileB.BaseStream.Seek(headerSize, SeekOrigin.Current);

            for (int row = 0; row < height; row++)
            {
                for (int col=0; col < width; col++)
                {
                    byte data = fileB.ReadByte();
                    if (data>=200) 
                        Console.Write(" ");
                    else if (data>=150 && data<=199)
                        Console.Write(".");
                    else if (data>=100 && data<=149)
                        Console.Write("-");
                    else if (data>=50 && data<=99)
                        Console.Write("=");
                    else
                        Console.Write("#");
                }
                Console.WriteLine();
            }
            fileB.Close();
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("Path too long");
            return 4;
        }
        catch (IOException ex)
        {
            Console.WriteLine("Input/output error: {0}", ex.Message);
            return 5;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unexpected error: {0}", ex.Message);
            return 6;
        }
        return 0;
    }
}
