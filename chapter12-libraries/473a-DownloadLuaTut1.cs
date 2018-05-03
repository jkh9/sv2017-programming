//Moisés Encinas Picazo

using System;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

public class DownloadLuaTut
{
    public static void Main()
    {
        Console.Write("Downloading LUA...");
        WebClient webClient = new WebClient();
        
        webClient.DownloadFile("https://www.lua.org/pil/contents.html",
                "contents.html");
        if (File.Exists("contents.html"))
        {
            string webPage = "";
            try
            {
                StreamReader input = new StreamReader("contents.html");
                string line;
                Regex r = new Regex("href.+html");
                
                do
                {
                    line = input.ReadLine();
                    if (line != null && r.IsMatch(line))
                    {
                        int num = line.IndexOf("href=")+6;
                        int num2 = line.IndexOf("html") + 4;
                        num2 = num2 - num;
                        webPage = line.Substring(num,num2);
                        webClient.DownloadFile("https://www.lua.org/pil/"+webPage,
                            webPage);
                        Console.Write(webPage+" ");
                    }
                } while (line != null);
                input.Close();
            }
            catch (Exception)
            {
                Console.Write("("+webPage+":error)");
            }
        }

    }
}
