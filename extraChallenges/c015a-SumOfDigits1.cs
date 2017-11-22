//Almudena Lopez Sanchez
//Challenge 15
using System;
public class Challenge15
{
    public static void Main()
    {
        string userNums;
        int sum;
        string text = "";
        do
        {
            text = "";   // Note: this line was missing
            sum = 0;
            userNums = Console.ReadLine();
            
            if (userNums != "-1")
            {
                foreach(char number in userNums)
                {
                    text = text + number + " + ";
                    sum += Convert.ToInt32(Convert.ToString(number));
                }
                int position = text.Length - 3;
                text = text.Remove(position,3);
                Console.Write(text);
                Console.Write(" = ");
                Console.WriteLine(sum);
            }
        }
        while (userNums != "-1");
    }
}
