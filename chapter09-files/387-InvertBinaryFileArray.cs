
using System;
using System.IO;

class Ex387
{
    static void Main(string[] args)
    {
        Console.Write("Enter file name: ");
        string fileName = Console.ReadLine();

        if (!File.Exists(fileName))
            Console.WriteLine("File Not found!");
        else
        {
            try
            {
                FileStream input = File.OpenRead(fileName);
                byte[] myByteArray = new byte[input.Length];
                int amount =
                    input.Read(myByteArray, 0, (int)input.Length);
                if (amount != input.Length)
                    Console.WriteLine("Read fail!");
                input.Close();

                Array.Reverse(myByteArray);

                FileStream output = File.OpenWrite(fileName + "2.txt");
                output.Write(myByteArray, 0, amount);
                output.Close();
            }
            catch (PathTooLongException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            catch (IOException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("Error!");
            }
        }
    }
}

