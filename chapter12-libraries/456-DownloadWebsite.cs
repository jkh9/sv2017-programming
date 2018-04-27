/*
Download the book "Learn Ruby the hard way", which has 52 chapters
with URLs similar to:

https://learnrubythehardway.org/book/ex1.html
*/

//Pedro Luis Coloma

using System;
using System.IO;
using System.Net;

public class DownloadBook
{
    public static void Main()
    {
        for (int i = 0; i <= 52; i++)
        {
            WebClient webClient = new WebClient();
            Stream connection =
                webClient.OpenRead(
                "https://learnrubythehardway.org/book/ex" + i + ".html");
            StreamReader reader = new StreamReader(connection);
            string data = reader.ReadToEnd();
            reader.Close();
            connection.Close();

            StreamWriter file = File.AppendText("ruby.html");
            file.WriteLine(data);
            file.Close();
        }
    }
}
