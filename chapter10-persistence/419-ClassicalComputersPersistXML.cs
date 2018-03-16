//Moisés Encinas Picazo

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Soap;

[Serializable]
struct Ram
{
    public string unit;
    public ushort size;
}

[Serializable]
struct Computer : IComparable
{
    public string brand;
    public string model;
    public ushort year;
    public Ram memory;
    public string comments;

    public int CompareTo(object obj)
    {
        Computer actual = (Computer)obj;

        if (String.Compare(this.brand + this.model,
                actual.brand + actual.model, true) > 0)
        {
            return 1;
        }
        else
        {
            return -1;
        }
    }
}

public class Ex417
{
    public static void Main()
    {
        List<Computer> computers = new List<Computer>();
        string option;
        bool finished = false;

        // If there is a data file, let's load it
        if (File.Exists("computers.xml"))
        {
            try
            {
                IFormatter formatter1 = new SoapFormatter();
                Stream stream1 = new FileStream("computers.xml",
                    FileMode.Open, FileAccess.Read,
                    FileShare.Read);
                computers = (List<Computer>)formatter1.Deserialize(stream1);
                stream1.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Read fail");
            }
        }

        // And then, to the main loop
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

            switch (option)
            {
                case "1":   // Add new data
                    Computer computerToAdd = new Computer();
                    do
                    {
                        Console.Write("Enter the brand: ");
                        computerToAdd.brand = Console.ReadLine();
                        if (computerToAdd.brand == "")
                            Console.WriteLine("The brand cannot be empty");
                    }
                    while (computerToAdd.brand == "");

                    do
                    {
                        Console.Write("Enter the model: ");
                        computerToAdd.model = Console.ReadLine();
                        if (computerToAdd.model.Length > 50)
                            Console.WriteLine("The model cannot be more "
                                + "than 50 letters");
                    }
                    while (computerToAdd.model.Length > 50);

                    Console.Write("Enter the year: ");
                    computerToAdd.year =
                        Convert.ToUInt16(Console.ReadLine());
                    if (computerToAdd.year < 1900)
                        computerToAdd.year = 0;

                    Console.Write("Enter the type of memory (eg KB): ");
                    computerToAdd.memory.unit = Console.ReadLine();

                    Console.Write("Enter the size of memory (eg 64): ");
                    computerToAdd.memory.size =
                        Convert.ToUInt16(Console.ReadLine());

                    Console.Write("Enter the comments: ");
                    computerToAdd.comments = Console.ReadLine();

                    computers.Add(computerToAdd);
                    break;

                case "2":   // Show brands and models
                    if (computers.Count == 0)
                        Console.WriteLine("No data available");
                    else
                    {
                        for (int i = 0; i < computers.Count; i++)
                        {
                            Console.WriteLine(computers[i].brand + " - " +
                                computers[i].model);
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
                        if (computers[i].brand.ToLower().Contains(str) ||
                            computers[i].model.ToLower().Contains(str) ||
                            computers[i].comments.ToLower().Contains(str))
                        {
                            datafound = true;
                            Console.WriteLine("Computer {0}", i + 1);
                            Console.WriteLine("Brand: {0}", computers[i].brand);
                            Console.WriteLine("Model: {0}", computers[i].model);
                            if (computers[i].year == 0)
                                Console.WriteLine("Year unknown");
                            else
                                Console.WriteLine("Year: {0}",
                                    computers[i].year);
                            Console.WriteLine("Memory: {0} {1}",
                                computers[i].memory.size,
                                computers[i].memory.unit);
                            Console.WriteLine("Comments: {0}",
                                computers[i].comments);
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
                        Computer computerToEdit = computers[num];

                        Console.WriteLine("Computer {0}", num + 1);
                        Console.WriteLine("Enter the new brand (it was {0})",
                            computers[num].brand);
                        string answer = Console.ReadLine();
                        if (answer != "")
                            computerToEdit.brand = answer;

                        Console.WriteLine("Enter the new model (it was {0})",
                            computers[num].model);
                        answer = Console.ReadLine();
                        if (answer != "")
                            computerToEdit.model = answer;

                        Console.WriteLine("Enter the new year (it was {0})",
                            computers[num].year);
                        answer = Console.ReadLine();
                        if (answer != "")
                            computerToEdit.year = Convert.ToUInt16(answer);

                        Console.WriteLine("Enter the new unit (it was {0})",
                            computers[num].memory.unit);
                        answer = Console.ReadLine();
                        if (answer != "")
                            computerToEdit.memory.unit = answer;

                        Console.WriteLine("Enter the new size (it was {0})",
                            computers[num].memory.size);
                        answer = Console.ReadLine();
                        if (answer != "")
                            computerToEdit.memory.size =
                                Convert.ToUInt16(answer);

                        Console.WriteLine("Enter the new comment (it was {0})",
                            computers[num].comments);
                        answer = Console.ReadLine();
                        if (answer != "")
                            computerToEdit.comments = answer;

                        computers[num] = computerToEdit;
                    }
                    break;

                case "5":   // Delete one record
                    Console.Write("Number of record to delete? ");
                    int pos = Convert.ToInt32(Console.ReadLine()) - 1;
                    if (pos >= computers.Count || pos < 0)
                        Console.WriteLine("Not a valid record");
                    else
                    {
                        computers.RemoveAt(pos);
                    }
                    break;

                case "6":  // Insert one record
                    Console.Write("Position to insert data? ");
                    pos = Convert.ToInt32(Console.ReadLine()) - 1;
                    if (pos >= computers.Count || pos < 0)
                        Console.WriteLine("Not a valid record");
                    else
                    {
                        Computer computerToInsert = new Computer();

                        Console.WriteLine("Computer {0}", pos + 1);
                        Console.Write("Brand: ");
                        computerToInsert.brand = Console.ReadLine();
                        Console.Write("Model: ");
                        computerToInsert.model = Console.ReadLine();
                        Console.Write("Year: ");
                        computerToInsert.year = Convert.ToUInt16(Console.ReadLine());
                        Console.Write("Memory type: ");
                        computerToInsert.memory.unit = Console.ReadLine();
                        Console.Write("Memory size: ");
                        computerToInsert.memory.size = Convert.ToUInt16(Console.ReadLine());
                        Console.Write("Comments: ");
                        computerToInsert.comments = Console.ReadLine();
                        computers.Insert(pos, computerToInsert);
                    }
                    break;

                case "7":   // Sort
                    computers.Sort();
                    break;

                case "8":   // Normalize descriptions
                    for (int i = 0; i < computers.Count; i++)
                    {
                        Computer computerToNormaliza = new Computer();
                        computerToNormaliza = computers[i];

                        computerToNormaliza.brand = computers[i].brand.Trim();
                        computerToNormaliza.model = computers[i].model.Trim();
                        computerToNormaliza.comments = computers[i].comments.Trim();

                        computers[i] = computerToNormaliza;
                    }
                    break;

                case "q":   // Quit
                case "Q":
                    finished = true;
                    break;
            }
        } while (!finished);
        Console.WriteLine("Bye!");

        try
        {
            // And let's save the data
            IFormatter formatter = new SoapFormatter();
            Stream stream = new FileStream("computers.xml",
                FileMode.Create, FileAccess.Write,
                FileShare.None);
            formatter.Serialize(stream, computers);
            stream.Close();
        }
        catch (Exception)
        {
            Console.WriteLine("Data could not be saved!");
        }
    }
}
