/*
Create a program that asks the user for a string and:

- Converts it to uppercase (storing the result in a new string)
- Converts it to lowercase (storing the result in a new string)
- Removes the second letter and the third letter (storing the result in a new string)
- Inserts "yo" after the second letter (storing the result in a new string)
- Replaces all spaces with underscores (storing the result in a new string)
- Removes leading spaces (storing the result in another string)
- Removes trailing spaces (storing the result in another string)
- Replaces all lowercase A by uppercase A (storing the result in another string)
- Split the text into an array of words which where separated by spaces and 
  display those words, each on in a line.

The program must display all the strings it generates.
*/

using System;

class StringsManipulation
{
    static void Main()
    {
        Console.WriteLine("Name? ");
        string name = Console.ReadLine();

        // - Converts it to uppercase(storing the result in a new string)
        string result = name.ToUpper();
        Console.WriteLine("Uppercase :" + result);

        // - Converts it to lowercase(storing the result in a new string)
        result = name.ToLower();
        Console.WriteLine("Lowercase :" + result);

        // - Removes the second letter and the third letter
        result = name.Remove(1,2);
        Console.WriteLine("No 2nd and 3rd letter :" + result);

        // - Inserts "yo" after the second letter
        result = name.Insert(2, "yo");
        Console.WriteLine("Inserting :" + result);

        // - Replaces all spaces with underscores
        result = name.Replace(" ", "_");
        Console.WriteLine("Underscored :" + result);

        // - Removes leading spaces
        result = name.TrimStart();
        Console.WriteLine("No leading spaces :" + 
            "." + result + ".");

        // - Removes trailing spaces
        result = name.TrimEnd();
        Console.WriteLine("No trailing spaces :" +
            "." + result + ".");

        // - Replaces all lowercase A by uppercase A
        result = name.Replace("a", "A");
        Console.WriteLine("\"a\" becomes \"A\" :" + result);

        // - Split the text into an array of words which where separated by
        //   spaces and display those words, each on in a line.
        Console.WriteLine("Words :");
        string[] fragments = name.Trim().Split();
        foreach (string word in fragments)
        {
            Console.WriteLine("  " + word);
        }
    }
}
