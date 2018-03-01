using System;
using System.IO;

public class PCXreader2
{

    public static void Main()
    {

        FileStream inputFile = File.OpenRead("ejemploPcx.pcx");
        int width=0,height=0;
        int xmin,xmax,ymin,ymax;
        byte mark = (byte) inputFile.ReadByte();
        byte [] data= new byte[8];
        inputFile.Seek(4,SeekOrigin.Begin);
        inputFile.Read(data,0,8);
        inputFile.Close();

        xmin=data[0]+data[1]*256;
        ymin=data[2]+data[3]*256;
        xmax=data[4]+data[5]*256;
        ymax=data[6]+data[7]*256;
        width=xmax-xmin+1;
        height=ymax-ymin+1;
        
        if (mark == 10)
        {
            Console.WriteLine("Width: {0}  Height: {1}",width,height);
        }
        else
        {
            Console.WriteLine("Not a PCX!");
        }
    
    }
}
