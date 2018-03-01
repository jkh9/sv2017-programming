using System;
using System.IO;

public class PCXreader1
{
    public static void Main()
    {
        BinaryReader myFile;
        
        myFile = new BinaryReader(File.Open("1.pcx", FileMode.Open));
        
        byte mark=myFile.ReadByte();
        if (mark != 10)
        {
            Console.WriteLine("Not a PCX file!");
        }
        else
        {
            myFile.BaseStream.Seek(4, SeekOrigin.Begin);
            short xMin=myFile.ReadInt16();
            short yMin=myFile.ReadInt16();
            short xMax=myFile.ReadInt16();
            short yMax=myFile.ReadInt16();
            Console.WriteLine("Width: " + (xMax-xMin+1));
            Console.WriteLine("Height: " + (yMax-yMin+1));
        }

        myFile.Close();
    }
}
