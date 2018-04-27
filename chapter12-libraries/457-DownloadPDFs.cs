/*
Download the challenges 100 to 199 from AceptaElReto.Com, in PDF format.

Hint: they are files named from

https://www.aceptaelreto.com/pub/problems/v001/00/st/problem.pdf

to

https://www.aceptaelreto.com/pub/problems/v001/99/st/problem.pdf

Hint: You should use WebClient.DownloadFile(Uri,String)
*/

//Luis Selles

using System;
using System.IO;
using System.Net;

public class DownloadChallenges
{
    public static void Main()
    {
        Console.Write("Downloading challenges...");
        WebClient webClient = new WebClient();
        for (int i = 0; i <= 2; i++)
        {
            Console.Write(" " + i);
            webClient.DownloadFile(
                "https://www.aceptaelreto.com/pub/problems/v001/"+
                i.ToString("00")+
                "/st/problem.pdf", 
                "challenge"+i.ToString("00")+".pdf" );
        }
    }
}
