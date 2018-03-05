// MP3 reader (ID3 v1)
// Version reading as a block

using System;
using System.IO;

public class Mp3Reader
{
    public static void Main(string[] args)
    {
        FileStream myFile;
        string fileName;

        if (args.Length != 0)
            fileName = args[0];
        else
        {
            Console.Write("Enter the name of the file: ");
            fileName = Console.ReadLine();
        }
        
        if (!File.Exists(fileName))
        {
            Console.WriteLine("File not found!");
            return;
        }
        
        byte[] data = new byte[128];
        myFile = new FileStream(fileName, FileMode.Open);
        myFile.Seek(-128, SeekOrigin.End);
        myFile.Read(data, 0, 128);
        myFile.Close();

        string tag = "";
        string title = "";
        string artist = "";
        string album = "";
        string year = "";
        string comment="";

        for (int i = 0; i < 3; i++)
            if(data[i] != 0)
                tag += (char) data[i];

        for (int i = 3; i < 33; i++)
            if(data[i] != 0)
                title += (char) data[i];

        for (int i = 33; i < 63; i++)
            if(data[i] != 0)
                artist += (char) data[i];

        for (int i = 63; i < 93; i++)
            if(data[i] != 0)
                album += (char)data[i];

        for (int i = 93; i < 97; i++)
            if(data[i] != 0)
                year += (char)data[i];

        for (int i = 97; i < 127; i++)
            if(data[i] != 0)
                comment += (char)data[i];

        if (tag == "TAG")
        {
            Console.WriteLine("ID " + tag);
            Console.WriteLine("Title " + title);
            Console.WriteLine("Artist " + artist);
            Console.WriteLine("Album " + album);
            Console.WriteLine("Year " + year);
            Console.WriteLine("Comment " + comment);
        }
        else
            Console.WriteLine("Not a MP3 with ID3 V1 header");
    }
}
