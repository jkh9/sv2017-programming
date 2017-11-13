/*
Create a program to manage a collection of videos (title, length in seconds, 
size in kb). It must allow the user to Add videos (option 1), Display all the 
videos (option 2) and Search (partial search, in title, option 3), sort the 
data on size (ascending, option 4), sort on title (option 5).
*/

// Gonzalo Martinez

using System;

struct Video
{
    public string title;
    public int length;
    public double size;
}

public class Ex175
{
    public static void Main()
    {
        Video[] videos = new Video[50000];
        int option, count = 0;
        
        do
        {
            Console.WriteLine("1.-Add video:");
            Console.WriteLine("2.-Show all:");
            Console.WriteLine("3.-Search video:");
            Console.WriteLine("4.-Sort by size:");
            Console.WriteLine("5.-Sort by title:");
            Console.WriteLine("0.-Exit");
            Console.WriteLine();
            
            option = Convert.ToInt32(Console.ReadLine());
            
            switch(option)
            {
                case 1:
                    Console.Write("Enter the title: ");
                    videos[count].title = Console.ReadLine();
                    Console.Write("Enter the length: ");
                    videos[count].length = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the size: ");
                    videos[count].size = Convert.ToDouble(Console.ReadLine());
                    count++;
                    break;
                    
                case 2:
                    for(int i = 0; i < count; i++)
                    {
                        Console.WriteLine("-Video {0}-", i + 1);
                        Console.WriteLine("Title: " + videos[i].title);
                        Console.WriteLine("Length: " + videos[i].length + 
                            " seconds");
                        Console.WriteLine("Size: " + videos[i].size + " kb");
                        Console.WriteLine();
                    }
                    break;
                    
                case 3:
                    Console.Write("Item to search: ");
                    string text = Console.ReadLine();
                    for(int i = 0; i < count; i++)
                    {
                        if(videos[i].title.ToLower().Contains(text.ToLower()))
                        {
                                Console.WriteLine("-Video {0}-", i + 1);
                                Console.WriteLine("Title: " + videos[i].title);
                                Console.WriteLine("Length: " + videos[i].length 
                                    + " seconds");
                                Console.WriteLine("Size: " + videos[i].size 
                                + " kb");
                                Console.WriteLine();
                        }
                    }
                    break;
                    
                case 4:
                    Video aux;
                    for(int i = 0; i < count - 1; i++)
                    {
                        for(int j = i + 1; j < count; j++)
                        {
                            if(videos[i].size > videos[j].size)
                            {
                                aux = videos[i];
                                videos[i] = videos[j];
                                videos[j] = aux;
                            }
                        }
                    }
                    break;
                    
                case 5:
                    for(int i = 0; i < count - 1; i++)
                    {
                        for(int j = i + 1; j < count; j++)
                        {
                            if(videos[i].title.ToUpper().CompareTo
                                (videos[j].title.ToUpper()) > 0)
                            {
                                aux = videos[i];
                                videos[i] = videos[j];
                                videos[j] = aux;
                            }
                        }
                    }
                    break;

                case 0:
                    Console.WriteLine("Bye!");
                    break;
                    
                default:
                    Console.WriteLine("Not an option");
                    break;
            }
           
       }while(option != 0);
    }
}
