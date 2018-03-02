/*
 - v0.10 - 28-Feb-2018 - Javier Saorín, Querubin Santana, Francisco Sabater.
 */
 
using System;
using System.Collections.Generic;
using System.IO;

public static class MapToFile
{
    public static bool ArrToFile(string[,] arrstrings)
    {
        List<byte> mylist = new List<byte>();

        

            foreach (string room in arrstrings)
            {

                byte translation = 0;

                if (room.Contains('U'))
                {
                    translation += 1;
                }

                if (room.Contains('D'))
                {
                    translation += 2;
                }

                if (room.Contains('R'))
                {
                    translation += 4;
                }

                if (room.Contains('L'))
                {
                    translation += 8;
                }

                mylist.Add(translation);
            }
        

        Console.WriteLine("Enter the name of the level");
        string levelname = Console.ReadLine();
        FileStream savefile = new FileStream(levelname, FileMode.Create);
        byte[] megadata = mylist.ToArray(); 
        savefile.Write(megadata,0,megadata.Length);
        savefile.Close();

            return true; 
       }
  
    
    }
