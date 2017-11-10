// Create the first approach to Task Manager program. It will allow 
// the user to store up to 1000 tasks. The main menu so far will be:
// 
// 1. Add a new task
// 2. View tasks
// 0. Exit

using System;

public class Tasks01
{
    struct task
    {
        public string description;
        public byte priority;
    }

    public static void Main()
    {
        const int SIZE = 1000;
        int currentPosition = 0;
        string option;
        bool finished = false;
        task[] tasks = new task[SIZE];

        do
        {
            Console.WriteLine("1. Add a new task");
            Console.WriteLine("2. View all tasks");
            Console.WriteLine("0. Exit");

            option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    if (currentPosition < SIZE - 1)
                    {
                        Console.Write("Enter the description:");
                        tasks[currentPosition].description = Console.ReadLine();
                        Console.Write("Enter the priority:");
                        tasks[currentPosition].priority = Convert.ToByte(
                            Console.ReadLine());

                        currentPosition++;
                    }
                    else
                    {
                        Console.WriteLine("Database full!");
                    }
                    break;

                case "2":
                    for (int i = 0; i < currentPosition; i++)
                    {
                        Console.WriteLine(
                            tasks[i].priority + " - " +
                            tasks[i].description);
                    }
                    break;

                case "0":
                    finished = true;
                    break;

                default: Console.WriteLine("Incorrect option"); break;
            }
        }
        while (!finished);
        Console.WriteLine("See you later!");
    }
}
