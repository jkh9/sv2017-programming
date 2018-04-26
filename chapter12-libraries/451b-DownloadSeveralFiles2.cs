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
            string data = reader.ReadToEnd();
            reader.Close();
            connection.Close();

            StreamWriter writer = new StreamWriter("ch" + i + ".html");
            writer.WriteLine(data);
            writer.Close();
        }
    }
}
