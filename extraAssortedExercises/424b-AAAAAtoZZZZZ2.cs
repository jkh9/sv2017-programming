// Display all the variations from aaaaa to zzzzz 
// (5 chars, letters a to z in the English alphabet... 
// and count them)

// Note: not a correct solution, the logic is broken
// The answer should be 26^5 = 11,881,376
// but the program reports  1,130,281

// Angel Rebollo

using System;

class PasswordWriter
{
    static void Main(string[] args)
    {
        char beginCharacter = 'a';
        char endCharacter = 'z';
        bool end = false;
        int count = 0;

        char c3 = 'a', c4 = 'a', c5 = 'a', 
            c6 = 'a', c7 = 'a';

        DateTime start = DateTime.Now;

        while(!end)
        {

            for (int j = 0; j < 9; j++)
            {

                if (c7 == endCharacter)
                {
                    c7 = beginCharacter;
                    c6++;
                }

                else if (c6 == endCharacter)
                {
                    c6 = beginCharacter;
                    c5++;
                }

                else if (c5 == endCharacter)
                {
                    c5 = beginCharacter;
                    c4++;
                }

                else if (c4 == endCharacter)
                {
                    c4 = beginCharacter;
                    c3++;
                }
                else
                    c7++;
            }

            //Console output

            Console.Write(Convert.ToString(c3));
            Console.Write(Convert.ToString(c4));
            Console.Write(Convert.ToString(c5));
            Console.Write(Convert.ToString(c6));
            Console.Write(Convert.ToString(c7));
            Console.Write(" ");
            count ++;

            if (c3 == endCharacter)
                end = true;
        }

        Console.WriteLine("Time to finish: " + (DateTime.Now - start));
        Console.WriteLine("Solutions found: " + count);
    }
}
