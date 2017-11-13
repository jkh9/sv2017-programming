/*
Create a program to manage a collection of videos (title, length in seconds, 
size in kb). It must allow the user to Add videos (option 1), Display all the 
videos (option 2) and Search (partial search, in title, option 3), sort the 
data on size (ascending, option 4), sort on title (option 5).
*/

// Javier Cases Sempere

using System;

struct Movie
{
    public string title;
    public int lengthSeconds; //In seconds
    public double sizeKb;
}

public class Ex181
{
    public static void Main()
    {
        const int SIZE = 10000;
        Movie[] movies = new Movie[SIZE];
        string option;
        int count = 0;

        do
        {
            Console.WriteLine("1.- Add");
            Console.WriteLine("2.- Show all");
            Console.WriteLine("3.- Search");
            Console.WriteLine("4.- Sort by Size");
            Console.WriteLine("5.- Sort by Title");
            Console.WriteLine("0.- Exit");
            Console.Write("Enter a option: ");
            option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    if (count < SIZE)
                    { 
                        Console.Write("Enter title of the video: ");
                        movies[count].title = Console.ReadLine();
                        Console.Write("Enter length in seconds: ");
                        movies[count].lengthSeconds = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter size in KB: ");
                        movies[count].sizeKb = Convert.ToInt16(Console.ReadLine());
                        count++;
                    }
                    else
                        Console.WriteLine("Error");
                    Console.WriteLine();
                    break;

                case "2":
                    for (int i = 0; i < count; i++)
                    {
                        Console.WriteLine("Title: " + movies[i].title);
                        Console.WriteLine("Length(Sec): " + movies[i].lengthSeconds);
                        Console.WriteLine("Size(Kb): " + movies[i].sizeKb);
                        Console.WriteLine();
                    }
                    break;

                case "3":
                    Console.Write("Enter a text to search: ");
                    string search = Console.ReadLine();

                    bool found = false;
                    for (int i = 0; i < count; i++)
                    {
                        if (movies[i].title.ToUpper().Contains(search.ToUpper()))
                        {
                            found = true;
                            Console.WriteLine("Title: " + movies[i].title);
                            Console.WriteLine("Length(sec): " + movies[i].lengthSeconds);
                            Console.WriteLine("Size(KB): " + movies[i].sizeKb);
                            Console.WriteLine();
                        }
                    }
                    if (!found)
                        Console.WriteLine("Not found");
                    break;

                case "4":
                    for (int i = 0; i < count - 1; i++)
                    {
                        for (int j = i + 1; j < count; j++)
                        {
                            if (movies[i].sizeKb > movies[j].sizeKb)
                            {
                                Movie temp = movies[j];
                                movies[j] = movies[i];
                                movies[i] = temp;
                            }
                        }
                    }
                    Console.WriteLine("By Size(Kb)");
                    break;

                case "5":

                    for (int i = 0; i < count - 1; i++)
                    {
                        for (int j = i + 1; j < count; j++)
                        {
                            if (String.Compare(movies[i].title, 
                                movies[j].title, true) > 0)
                            {
                                Movie temp = movies[j];
                                movies[j] = movies[i];
                                movies[i] = temp;
                            }
                        }
                    }
                    Console.WriteLine("By Title");

                    break;

                case "0":
                    Console.WriteLine("Bye!");
                    break;

                default:
                    Console.WriteLine("Wrong option, enter a valid option");
                    Console.WriteLine();
                    break;
            }
        }
        while (option != "0");
    }
}
