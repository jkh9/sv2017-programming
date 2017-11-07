//Victor Tebar
//

using System;

public class Ejer{
    public static void Main(){
        string sentence;
        int numTimes;
        
        numTimes = Convert.ToInt32(Console.ReadLine());
        
        for(int i=0;i<numTimes;i++){
            sentence = Console.ReadLine();
            string[] separated = sentence.Split();
            sentence = "";
            for(int j=0;j<separated.Length;j++)
                sentence = separated[j] + " " + sentence;
            Console.WriteLine("Case #{0}: {1}",i+1,sentence.TrimEnd());
        }
    }
}
