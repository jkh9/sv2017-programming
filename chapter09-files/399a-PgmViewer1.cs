// PGM Viewer
// Version 1: FileStream + Split for size

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
            // File read
            FileStream file = File.OpenRead(fileName);
            int size = (int) file.Length;
            byte[] data = new byte[size];
            file.Read(data,0,size);
            file.Close();
            
            // Header 1: P5
            if ((data[0] != 'P') || (data[1] != '5') || (data[2] != 0x0a))
            {
                Console.WriteLine("Not a P5 PGM file");
                return 3;
            }
           
            // Header 2: size
            int pos=3;
            string sizeAsString = "";
            do
            {
                sizeAsString += Convert.ToChar(data[pos]);
                pos++;
            }
            while(data[pos] != 10);
            
            string[] widthAndHeight = sizeAsString.Split(' ');
            int width = Convert.ToInt32(widthAndHeight[0]);
            int height = Convert.ToInt32(widthAndHeight[1]);
            Console.WriteLine("Size: {0} x {1}", width, height);
            
            // Header 3: Shades of grey
            pos++;
            if ((data[pos] != '2') || (data[pos+1] != '5') || 
                (data[pos+2] != '5'))
            {
                Console.WriteLine("Not a 255 levels of grey P5 PGM file");
                return 3;
            }
            
            // And data
            int pixelsDrawn = 0;
            pos += 4;
            for (int i=pos; i<size; i++)
            {
                if (data[i]>=200) 
                    Console.Write(" ");
                else if (data[i]>=150 && data[i]<=199)
                    Console.Write(".");
                else if (data[i]>=100 && data[i]<=149)
                    Console.Write("-");
                else if (data[i]>=50 && data[i]<=99)
                    Console.Write("=");
                else
                    Console.Write("#");
                pixelsDrawn++;
                if (pixelsDrawn == width)
                {
                    Console.WriteLine();
                    pixelsDrawn = 0;
                }
            }
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
