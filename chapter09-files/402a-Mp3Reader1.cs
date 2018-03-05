// Javier Saorín Vidal

using System;
using System.IO;

class Mp3Reader
{
    public static void Main()
    {
        Console.Write("Enter file name: ");
        string fileName = Console.ReadLine();
        
        if (!File.Exists(fileName))
            Console.WriteLine(fileName + " is not a valid file name!");
        else
        {
            try
            {
                FileStream input = File.OpenRead(fileName);

                input.Seek(-128, SeekOrigin.End);
                byte b1, b2, b3;
                char c;

                b1 = (byte)input.ReadByte();
                b2 = (byte)input.ReadByte();
                b3 = (byte)input.ReadByte();

                if (b1 == 'T' && b2 == 'A' && b3 == 'G')
                {
                    string title = "";
                    for (int i = 0; i < 30; i++)
                    {
                        c = (char) input.ReadByte();
                        if (c != '\0')
                            title += c;
                    }
                    title = title.Trim();

                    string artist = "";
                    for (int i = 0; i < 30; i++)
                    {
                        c = (char) input.ReadByte();
                        if (c != '\0')
                            artist += c;
                    }
                    artist = artist.Trim();

                    string album = "";
                    for (int i = 0; i < 30; i++)
                    {
                        c = (char) input.ReadByte();
                        if (c != '\0')
                            album += c;
                    }
                    album = album.Trim();

                    string year = "";
                    for (int i = 0; i < 4; i++)
                    {
                        c = (char) input.ReadByte();
                        if (c != '\0')
                            year += c;
                    }

                    string musicalGenre = "";
                    musicalGenre += input.ReadByte();

                    input.Close();

                    Console.WriteLine("TITLE: " + title);
                    Console.WriteLine("ARTIST: " + artist);
                    Console.WriteLine("ALBUM: " + album);
                    Console.WriteLine("YEAR: " + year);
                    Console.WriteLine("GENRE: " + musicalGenre);
                }
                else
                {
                    Console.WriteLine("Not a valid MP3 file.");
                }
                input.Close();

            }
            catch (PathTooLongException pl)
            {
                Console.WriteLine("PATH TOO LONG EXCEPTION: " + pl.Message);
            }
            catch (IOException ioEx)
            {
                Console.WriteLine("INPUT/OUTPUT ERROR: " + ioEx.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: " + e.Message);
            }
        }
    }
}
