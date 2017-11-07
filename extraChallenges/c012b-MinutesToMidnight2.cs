// Minutes to midnight
// Miguel Puerta

using System;

public class CH12
{
    public static void Main()
    {
        int min, hour;
        
        string time = Console.ReadLine();
        
        while( time != "00:00" )
        {
            string[] arrayTime = time.Split(':');
            hour = Convert.ToInt32(arrayTime[0]);
            min = Convert.ToInt32(arrayTime[1]);
            
            min = 60 - min;
            
            if( min > 0 )
                hour++;
                
            if( hour != 24 )
            {
                hour = 24 - hour;
                min += hour * 60;
            }
            
            Console.WriteLine(min);
            
            time = Console.ReadLine();
        }
    }
}
