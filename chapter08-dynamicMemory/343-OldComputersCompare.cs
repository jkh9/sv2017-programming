/*
Create a C# program that can store up to 600 records of classical computers.
For each computer, you must keep the following data:

• Brand Name (eg Amstrad)

• Model (eg CPC664)

• Year (eg 1984)

• RAM (set of 2 data: the measure unit, eg Kb, and size, eg 64)

• Comments

The program should allow the user the following operations:

1 - Add a new computer data (the brand must not be empty, the model should not
occupy more than 50 letters, and if any of them is not valid, it must be
entered again. If the year is before 1900, it should be stored as 0, to
indicate that it is not valid).

2 - Show all brands and models of computers stored. Each computer (brand and
model) should appear on one line, separated by a hyphen (eg "Amstrad - CPC664").
The program should pause after displaying each block of 24 computers, display
the message "Press Enter to continue" and wait until the user presses Enter.
The user should be notified if there is no data.

3 - Search for computers that contain a certain text (as part of its brand,
model or comments, case insensitive). If the year is 0, it should display:
"Year: unknown." Data must be displayed on separate lines, with an extra blank
line after each computer. The user should be notified if none is found.

4 - Update a record (the program will ask for the number, will display the
previous value of each field and the user can press Enter not to modify any of
the data). The user should be warned (but not asked again) if he enters an
incorrect record number. It is not necessary to validate any of the fields.

5 - Delete some data, in the position indicated by the user. The user should be
warned (but not asked again) if he enters an incorrect record number.

6 - Insert data in a position chosen by the user (by moving the rest of the
records to the right). The user should be warned (but not asked again) if he
enters an incorrect record number.

7 - Sort the data alphabetically by brand+model.

8 - Remove extra spaces (initial and final spaces in all the brands, models and
comments. For example, a comment like " Test Data " would become "Test Data".

Q - Quit (end the application; as we do not store the information, will be lost).

(Ex.330: with ArrayList)

*/

using System;
using System.Collections;

public struct Ram
{
    public string unit;
    public ushort size;
}
public struct Computer : IComparable
{
    public string brand;
    public string model;
    public ushort year;
    public Ram memory;
    public string comments;

    public int CompareTo(Object c2)
    {
        return (brand+model).CompareTo(
            ((Computer)c2).brand+ ((Computer)c2).model);
    }
}

public class Ex192
{
    public static void Main()
    {
        ArrayList computers = new ArrayList();
        string option;
        bool finished = false;

        do
        {
            Console.WriteLine("1.Add data");
            Console.WriteLine("2.Show brands & models");
            Console.WriteLine("3.Search computers");
            Console.WriteLine("4.Update information");
            Console.WriteLine("5.Delete data");
            Console.WriteLine("6.Insert data");
            Console.WriteLine("7.Sort alphabetically");
            Console.WriteLine("8.Remove extra spaces");
            Console.WriteLine("Q.Exit");
            Console.WriteLine();

            Console.Write("Choose an option: ");
            option = Console.ReadLine();

            Computer c;
            switch (option)
            {
                case "1":   // Add new data
                    do
                    {
                        Console.Write("Enter the brand: ");
                        c.brand = Console.ReadLine();
                        if (c.brand == "")
                            Console.WriteLine("The brand cannot be empty");
                    }
                    while (c.brand == "");

                    do
                    {
                        Console.Write("Enter the model: ");
                        c.model = Console.ReadLine();
                        if (c.model.Length > 50)
                            Console.WriteLine("The model cannot be more "
                                + "than 50 letters");
                    }
                    while (c.model.Length > 50);

                    Console.Write("Enter the year: ");
                    c.year =
                        Convert.ToUInt16(Console.ReadLine());
                    if (c.year < 1900)
                        c.year = 0;

                    Console.Write("Enter the type of memory (eg KB): ");
                    c.memory.unit = Console.ReadLine();

                    Console.Write("Enter the size of memory (eg 64): ");
                    c.memory.size =
                        Convert.ToUInt16(Console.ReadLine());

                    Console.Write("Enter the comments: ");
                    c.comments = Console.ReadLine();

                    computers.Add(c);
                    break;

                case "2":   // Show brands and models
                    if (computers.Count == 0)
                        Console.WriteLine("No data available");
                    else
                    {
                        for (int i = 0; i < computers.Count; i++)
                        {
                            c = (Computer) computers[i];
                            Console.WriteLine(c.brand + " - " +
                                c.model);
                            if (i % 24 == 23)
                            {
                                Console.WriteLine("Press Enter to continue");
                                Console.ReadLine();
                            }
                        }
                    }
                    break;

                case "3":   // Search
                    bool datafound = false;
                    Console.Write("Text to search? ");
                    string str = Console.ReadLine().ToLower();
                    for (int i = 0; i < computers.Count; i++)
                    {
                        c = (Computer)computers[i];
                        if (c.brand.ToLower().Contains(str) ||
                            c.model.ToLower().Contains(str) ||
                            c.comments.ToLower().Contains(str))
                        {
                            datafound = true;
                            Console.WriteLine("Computer {0}", i + 1);
                            Console.WriteLine("Brand: {0}", c.brand);
                            Console.WriteLine("Model: {0}", c.model);
                            if (c.year == 0)
                                Console.WriteLine("Year unknown");
                            else
                                Console.WriteLine("Year: {0}",
                                    c.year);
                            Console.WriteLine("Memory: {0} {1}",
                                c.memory.size,
                                c.memory.unit);
                            // Let's modify the comments with a different syntax
                            Console.WriteLine("Comments: {0}",
                                ((Computer) computers[i]).comments);
                            Console.WriteLine();
                        }
                    }
                    if (!datafound)
                        Console.WriteLine("Data not found");
                    break;

                case "4":   // Modify
                    Console.Write("Number of record to modify? ");
                    int num = Convert.ToInt32(Console.ReadLine()) - 1;
                    if (num >= computers.Count || num < 0)
                        Console.WriteLine("Not a valid record number");
                    else
                    {
                        c = (Computer)computers[num];
                        Console.WriteLine("Computer {0}", num + 1);
                        Console.WriteLine("Enter the new brand (it was {0})",
                            c.brand);
                        string answer = Console.ReadLine();
                        if (answer != "")
                            c.brand = answer;

                        Console.WriteLine("Enter the new model (it was {0})",
                            c.model);
                        answer = Console.ReadLine();
                        if (answer != "")
                            c.model = answer;

                        Console.WriteLine("Enter the new year (it was {0})",
                            c.year);
                        answer = Console.ReadLine();
                        if (answer != "")
                            c.year = Convert.ToUInt16(answer);

                        Console.WriteLine("Enter the new unit (it was {0})",
                            c.memory.unit);
                        answer = Console.ReadLine();
                        if (answer != "")
                            c.memory.unit = answer;

                        Console.WriteLine("Enter the new size (it was {0})",
                            c.memory.size);
                        answer = Console.ReadLine();
                        if (answer != "")
                            c.memory.size =
                                Convert.ToUInt16(answer);

                        Console.WriteLine("Enter the new comment (it was {0})",
                            c.comments);
                        answer = Console.ReadLine();
                        if (answer != "")
                            c.comments = answer;

                        computers[num] = c;
                    }
                    break;

                case "5":   // Delete one record
                    Console.Write("Number of record to delete? ");
                    int pos = Convert.ToInt32(Console.ReadLine()) - 1;
                    if (pos >= computers.Count || pos < 0)
                        Console.WriteLine("Not a valid record");
                    else
                        computers.RemoveAt(pos);
                    break;

                case "6":  // Insert one record
                    Console.Write("Position to insert data? ");
                    pos = Convert.ToInt32(Console.ReadLine()) - 1;
                    if (pos >= computers.Count || pos < 0)
                        Console.WriteLine("Not a valid record");
                    else
                    {
                        Console.WriteLine("Computer {0}", pos + 1);
                        Console.Write("Brand: ");
                        c.brand = Console.ReadLine();
                        Console.Write("Model: ");
                        c.model = Console.ReadLine();
                        Console.Write("Year: ");
                        c.year = Convert.ToUInt16(Console.ReadLine());
                        Console.Write("Memory type: ");
                        c.memory.unit = Console.ReadLine();
                        Console.Write("Memory size: ");
                        c.memory.size = Convert.ToUInt16(Console.ReadLine());
                        Console.Write("Comments: ");
                        c.comments = Console.ReadLine();
                        computers.Insert(pos, c);
                    }
                    break;

                case "7":   // Sort
                    computers.Sort();
                    break;

                case "8":   // Normalize descriptions
                    for (int i = 0; i < computers.Count; i++)
                    {
                        c = (Computer) computers[i];
                        c.brand = c.brand.Trim();
                        c.model = c.model.Trim();
                        c.comments = c.comments.Trim();
                        computers[i] = c;
                    }
                    break;

                case "q":   // Quit
                case "Q":
                    finished = true;
                    break;
            }
        } while (!finished);
        Console.WriteLine("Bye!");
    }
}
