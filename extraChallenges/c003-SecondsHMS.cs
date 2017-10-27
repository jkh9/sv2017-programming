//Daniel Miquel Sirera
//Reto3

using System;

public class Reto003{
    
        public static void Main(){
        
        byte casos,minutes,hours;
        int time;
        
        minutes = 0;
        hours = 0;
        
        casos = Convert.ToByte(Console.ReadLine());
        
        for(int i=0;i<casos;i++){
            
            time = Convert.ToInt32(Console.ReadLine());
            if(time<=86400){
               while(time>=3600){
                   hours++;
                   time-=3600;
               }
               while(time>=60){
                   minutes++;
                   time-=60;
               }
               Console.WriteLine("{0}:{1}:{2}",hours.ToString("00"),
               minutes.ToString("00"),time.ToString("00"));
           }
       }
        
    }
}
            
