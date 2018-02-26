// Create a program to split a file (of any kind) into pieces of a certain size. 
// it must receive the name of the file and the size as parameters. For example, 
// it might be used by writing:
// 
// split myFile.exe 2000
// 
// If the file "myFile.exe" is 4500 bytes long, that command would produce a file 
// named "myFile.exe.001" 2000 bytes long, another called "myFile.exe.002" 2000 
// bytes long, and another named "myFile.exe.003" 500 bytes long.

using System;
using System.IO;

class FileSplitter
{
    static int Main(string[] args)
    {
        FileStream inputFile;
        string fileName = "";
        int blockSize = 0;
        int blockNumber = 1;

        if (args.Length!= 2)
        {
            Console.WriteLine("Missing parameters");
            Console.WriteLine("Usage: split fileName sizeInBytes");
            return 1;
        }
        else
        {
            try
            {
                fileName = args[0];
                blockSize = Convert.ToInt32(args[1]);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid size");
                Console.WriteLine("Usage: split fileName sizeInBytes");
                return 2;
            }
        }

        try
        {
            inputFile = new FileStream(fileName, FileMode.Open);
            byte[] data = new byte[blockSize];
            int bytesRead = 0;
            do
            {
                bytesRead = inputFile.Read(data, 0, blockSize);

                if (bytesRead != 0)
                {
                    string strCounter = blockNumber.ToString("000");
                    FileStream outFile = new FileStream(
                        fileName+"."+strCounter, FileMode.Create);
                    outFile.Write(data, 0, bytesRead);
                    outFile.Close();
                }

                blockNumber++;
            }
            while(bytesRead == blockSize);
            inputFile.Close();
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("Path too long");
            return 3;
        }
        catch (IOException e)
        {
            Console.WriteLine("Input/output error: " + e.Message);
            return 4;
        }
        catch (Exception e)
        {
            Console.WriteLine("Unexpected error: " + e.Message);
            return 5;
        }

        return 0;
    }
}
