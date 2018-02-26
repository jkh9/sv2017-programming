// Create a program to copy a source file into a destination file, 
// with a user-specified block size:
// 
// copy myFile.exe nyNewFile.exe 2000
// 
// If the file "myFile.exe" is 4500 bytes long, that command would 
// take three passes (2000+2000+500) to dump the whole file.

using System;
using System.IO;

class FileSplitter
{
    static void Main(string[] args)
    {
        FileStream inputFile;
        string sourceFileName = "";
        string destFileName = "";
        int blockSize = 0;
        int blockNumber = 1;

        if (args.Length != 3)
        {
            Console.WriteLine("Missing parameters");
            Console.WriteLine("Usage: copy sourceFileName destFileName blockSize");
        }
        else
        {
            sourceFileName = args[0];
            destFileName = args[1];
            blockSize = Convert.ToInt32(args[2]);
        }

        if (!File.Exists(sourceFileName))
        {
            Console.WriteLine("Doesn't exist the source file");
        }
        else
        {
            try
            {
                inputFile = new FileStream(sourceFileName, FileMode.Open);
                FileStream outFile = new FileStream(destFileName, FileMode.Create);
                byte[] data = new byte[blockSize];
                int bytesRead = 0;
                do
                {
                    bytesRead = inputFile.Read(data, 0, blockSize);

                    if (bytesRead != 0)
                    {
                        outFile.Write(data, 0, bytesRead);
                    }
                }
                while (bytesRead == blockSize);
                outFile.Close();
                inputFile.Close();
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("Path too long");
            }
            catch (IOException e)
            {
                Console.WriteLine("Input/output error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}
