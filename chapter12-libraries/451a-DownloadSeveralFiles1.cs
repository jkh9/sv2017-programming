// Download the challenges 100 to 199 from AceptaElReto.com:

// https://www.aceptaelreto.com/problems/volumes.php/?vol=71

using System;
using System.IO;
using System.Net;

public class DownloadChallenges
{
    public static void Main()
    {
        Console.Write("Downloading challenges...");
        for (int i = 100; i <= 199; i++)
        {
            Console.Write(" "+i);
            WebClient webClient = new WebClient();
            Stream connection =
                webClient.OpenRead(
                "https://www.aceptaelreto.com/problem/statement.php?id=" + i);
            StreamReader reader = new StreamReader(connection);
            StreamWriter writer = new StreamWriter("ch" + i + ".html");
            string line;
            do
            {
                line = reader.ReadLine();
                if (line != null)
                {
                    writer.WriteLine(line);
                }
            } while (line != null);
            writer.Close();
            reader.Close();
            connection.Close();
        }
    }
}
