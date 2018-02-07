/*
Prepare a "dictionary file creator". It will ask for words an their meanings. 
When the user answer with an empty string, data will be dumped to file named 
"dictionary.txt" using File.WriteAllLines.

The format of the data in the file must be as follows:

hola=hello
uno=one
dos=two
*/

// Javier Saorín Vidal

using System;
using System.IO;
using System.Collections;

class ArrayListTest
{
    static void Main()
    {
        ArrayList data = new ArrayList();
        string word = "", meaning = "";

        do
        {
            Console.Write("Word? ");
            word = Console.ReadLine();

            if (word != "")
            {
                Console.Write("Meaning? ");
                meaning = Console.ReadLine();

                if (meaning != "")
                    data.Add(word + "=" + meaning);
            }
        }
        while (word != "" && meaning != "");

        string[] dataToFile = new string[data.Count];
        for (int i = 0; i < data.Count; i++)
            dataToFile[i] = (string) (data[i]);
        File.WriteAllLines("data.txt", dataToFile);
    }
}

