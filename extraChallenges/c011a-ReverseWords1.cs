//
// Miguel Puerta

using System;

public class CH11
{
    public static void Main()
    {
        byte n = Convert.ToByte(Console.ReadLine());
        
        for(int time = 0; time < n; time++)
        {
            string sentence = Console.ReadLine();            
            string[] words = sentence.Split();
            Console.Write("Case #" + (time + 1) + ": ");
            for(int word = words.Length - 1; word > 0; word--)
                Console.Write(words[word] + " ");
            Console.WriteLine(words[0]);
        }
    }
}
