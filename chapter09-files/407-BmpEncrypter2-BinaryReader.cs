// Javier Saorín Vidal

using System;
using System.IO;

class BMPEncrypter
{
    public static void Main()
    {
        Console.Write("Enter file name: ");
        string fileName = Console.ReadLine();

        if (!File.Exists(fileName))
        {
            Console.WriteLine(fileName + " is not a valid file name!");
        }
        else
        {
            try
            {
                BinaryReader input =
                    new BinaryReader(File.Open(fileName, FileMode.Open));

                byte b1 = input.ReadByte();
                byte b2 = input.ReadByte();

                BinaryWriter output =
                    new BinaryWriter(File.Open(fileName, 
                        FileMode.CreateNew));

                output.Write(b2);
                output.Write(b1);

                for (int i = 2; i < input.BaseStream.Length; i++)
                    output.Write(input.ReadByte());

                input.Close();
                output.Close();
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("PATH TOO LONG: ");
            }
            catch (IOException e)
            {
                Console.WriteLine("INPUT/OUTPUT ERROR: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: " + e.Message);
            }
        }
    }
}
