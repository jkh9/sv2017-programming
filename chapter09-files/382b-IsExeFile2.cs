//Pedro Luis Coloma

using System;
using System.IO;

public class ExeOrNotExe
{
    public static void Main()
    {
        Console.Write("Enter a file name: ");
        string name = Console.ReadLine();

        if (!File.Exists(name))
        {
            Console.WriteLine("File not found!");
        }
        else
        {
            try
            {
                FileStream myFile = new FileStream(
                    name, FileMode.Open);
                byte data;
                bool firstLetterCorrect = false;
                bool secondLetterCorrect = false;

                data = (byte) myFile.ReadByte();                
                if (data == 'M')
                {
                    firstLetterCorrect = true;
                }
                
                data = (byte) myFile.ReadByte();
                if (data == 'Z')
                {
                    secondLetterCorrect = true;
                }
                myFile.Close();

                if (firstLetterCorrect && secondLetterCorrect)
                {
                    Console.WriteLine("Seems a real EXE file.");
                }
                else
                {
                    Console.WriteLine("It's not an EXE file");
                }
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("Path too long");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not accessible");
            }
            catch (IOException e)
            {
                Console.WriteLine("I/O error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Oooops... " + e.Message);
            }
        }
    }
}
