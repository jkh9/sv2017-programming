/*
 *  Maze Game
 * 
 * V0.10. 28-Feb-2018, Sabater, Querubin, Saorin
 * V0.11 20-Abr-2018 Nacho: Compilation error solved ("return" missing)
 */

using System;
using System.IO;
using System.Collections.Generic;

public class ReadMapFile
{
    public static string[] LoadMap(string filename)
    {
        string[] map = new string[24];

        if (File.Exists(filename))
        {

            FileStream fileread = new FileStream(filename, FileMode.Open);

            long con = fileread.Length;

            byte[] arraybytes = new byte[con];

            int linesreaded = fileread.Read(arraybytes, 0, arraybytes.Length);
            fileread.Close();


            foreach (byte bait in arraybytes)
            {
                string baitstring = Convert.ToString(bait, 2);

                while (baitstring.Length < 4)
                {
                    baitstring = "0" + baitstring;
                }

                string tempstring = "";


                if (baitstring[0] == 1)
                {
                    tempstring += "U";
                }

                if (baitstring[1] == 1)
                {
                    tempstring += "D";
                }

                if (baitstring[2] == 1)
                {
                    tempstring += "R";
                }

                if (baitstring[3] == 1)
                {
                    tempstring += "L";
                }

                Console.WriteLine(tempstring);

            }
        }
        return map;
    }
}

