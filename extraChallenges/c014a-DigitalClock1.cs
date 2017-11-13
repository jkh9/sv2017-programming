//Almudena Lopez Sanchez
//Challenge 014 - Reloj digital

/*
You have a digital, 7 led segment, clock. One day, while waking up from a 
sci-fi dream, you wonder: how many times will the individual leds turn on after 
X seconds, from a 00:00:00 position?

Yeah, geeks. But as a good geek you will not that question stay on your mind 
forever, right? ;)

Take into account that every second, all leds turn off and then the ones for 
the next position will turn on.

Sample input
0
4
1000
36000


Sample output
36
172
30630
1069232
*/

using System;
public class Challenge14
{
    public static void Main()
    {
        string answer = Console.ReadLine();
        while (answer != "")
        {
            int count = 0;
            long userSeconds = Convert.ToInt64(answer);
            string clock= "000000";
            int seconds=0;
            int sec=0,min=0,hours=0;
            
            do
            {
                for(int num = 0; num<clock.Length;num++)
                {
                    switch (clock.Substring(num,1))
                    {
                        case "0":
                        case "6":
                        case "9":
                            count+=6;
                            break;
                        case "1":
                            count+=2;
                            break;
                        case "2":
                        case "3":
                        case "5":
                            count+=5;
                            break;
                        case "4":
                            count+=4;
                            break;
                        case "7":
                            count+=3;
                            break;
                        case "8":
                            count+=7;
                            break;
                    }
                }
                seconds++;
                hours = seconds/3600;
                min = (seconds%3600)/60;
                sec = (seconds%3600)%60;
                clock = hours.ToString("00")+min.ToString("00")+sec.ToString("00");
                userSeconds--;
            }
            while(userSeconds >= 0);
            Console.WriteLine(count);

            answer = Console.ReadLine();
        }
    }
}
