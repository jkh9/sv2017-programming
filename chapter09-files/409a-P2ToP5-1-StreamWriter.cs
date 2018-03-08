// Basic PGM P2 to P5 Converter

using System;
using System.IO;

class P2toP5
{
    static void Main(string[] args)
    {
        StreamReader myReader;
        StreamWriter myWriter;
        string fileName = "";
        string fileName2 = "";
        string line = "";

        Console.WriteLine("Enter the P2 PGM file to convert: ");
        fileName = Console.ReadLine();

        Console.WriteLine("Enter the P5 PGM file to create: ");
        fileName2 = Console.ReadLine();

        if (!File.Exists(fileName))
        {
            Console.WriteLine("The P2 PGM file doesn't exist.");
            return;
        }

        myReader = new StreamReader(fileName);
        string data = "";
        line = myReader.ReadLine();
        while (line != null)
        {
            data = data + line + " ";
            line = myReader.ReadLine();
        }
        myReader.Close();

        string[] details = data.Split(' ');
        if (details[0] != "P2")
        {
            Console.WriteLine("Not a P2 PGM file!");
            return;
        }
        int width = Convert.ToInt32(details[1]);
        int height = Convert.ToInt32(details[2]);
        int colors = Convert.ToInt32(details[3]);

        string header = "P5\n" + width + " " + height + "\n" + colors + "\n";
        myWriter = new StreamWriter(fileName2);
        myWriter.Write(header);
        myWriter.Close();

        BinaryWriter myWriter2 = new BinaryWriter(
            File.Open(fileName2, FileMode.Append));
        for (int i = 4; i < details.Length; i++)
        {
            if (details[i].Length > 0)
                myWriter2.Write(Convert.ToByte(details[i]));
        }
        myWriter2.Close();

        Console.WriteLine("Finished");
    }
}
