// PGM Viewer
// Version 3: BinaryReader

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
            BinaryReader file = new BinaryReader(
				File.Open(fileName, FileMode.Open));
                        
            // Header 1: P5
            byte mark1, mark2, mark3;
			mark1 = file.ReadByte();
			mark2 = file.ReadByte();
			mark3 = file.ReadByte();
			
            if ((mark1 != 'P') || (mark2 != '5') || (mark3 != 0x0a))
            {
                Console.WriteLine("Not a P5 PGM file");
                return 3;
            }
            
            // Header 2: size
            byte data;
            string widthAsString = "";
            data = file.ReadByte();
            do
            {
                widthAsString += Convert.ToChar(data);
                data = file.ReadByte();
            }
            while(data != ' ');
            int width = Convert.ToInt32(widthAsString);
            
            string heightAsString = "";
            do
            {
                heightAsString += Convert.ToChar(data);
                data = file.ReadByte();
            }
            while(data != 0x0a);
            int height = Convert.ToInt32(heightAsString);
            
            Console.WriteLine("Size: {0} x {1}", width, height);
            
            // Header 3: Shades of grey -> Skipped
            file.BaseStream.Seek(4, SeekOrigin.Current);
            
            // And data
            for (int row = 0; row < height; row++)
            {
                for (int col=0; col < width; col++)
                {
                    data = file.ReadByte();
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
            file.Close();
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
