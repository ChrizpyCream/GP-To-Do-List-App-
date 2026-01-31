using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;

class Program
{
    static List<TodoTask> tasks = new List<TodoTask>();
    static void Main()
    {

        Menu menu = new Menu();
        menu.ShowWelcomeMessage();

        bool running = true;

        while (running)
        {
            Console.Clear();
            menu.ShowMainMenu();

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddTask();
                    break;

                case "2":
                    RemoveTask();
                    break;

                case "3":
                    ViewTasks();
                    Pause();
                    break;

                case "4":
                    MarkTaskCompleted();
                    break;

                case "5":
                    running = false;
                    Exit();
                    break;

                default:
                    Console.WriteLine("Please enter a number between 1 and 5.");
                    Console.ReadKey(true);
                    break;
            }
        }
    }

    static void AddTask()
    {
        Console.Clear();

        Console.WriteLine("✧⋄⋆⋅⋆⋄✧ Add New Task ✧⋄⋆⋅⋆⋄✧");
        Console.Write("What do you need to do? ");
        string taskDescription = Console.ReadLine();

        DateTime dueDate;

        while (true)
        {
            System.Console.WriteLine("Enter due date (yyyy-mm-dd) or press enter for default (7 days):");
            string dueDateInput = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(dueDateInput))
            {
                dueDate = DateTime.Now.AddDays(7);
                Console.WriteLine("Task added with default due date (7 days)");
                break;
            }
            else if (!DateTime.TryParse(dueDateInput, out dueDate))
            {
                Console.WriteLine("Invalid date format. Please enter a valid date (yyyy-mm-dd).");
                continue;
            }
            else
            {
                Console.WriteLine("Task added with due date " + dueDate.ToString("yyyy-MM-dd"));
                break;
            }
        }

        TodoTask newTask = new TodoTask(taskDescription, dueDate);
        tasks.Add(newTask);

        Pause();
    }

    static void RemoveTask()
    {
        Console.Clear();

        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks to remove.");
            Pause();
            return;
        }

        ViewTasks();

        Console.Write("Enter task number to remove: ");
        string input = Console.ReadLine();

        int taskNumber;
        bool isNumber = int.TryParse(input, out taskNumber);

        if (isNumber && taskNumber >= 1 && taskNumber <= tasks.Count)
        {
            tasks.RemoveAt(taskNumber - 1);
            Console.WriteLine("Task removed!");
        }
        else
        {
            Console.WriteLine("Invalid number!");
        }

        Pause();
    }

    static void MarkTaskCompleted()
    {
        Console.Clear();

        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks completed.");
            Pause();
            return;
        }

        ViewTasks();
        Console.Write("\nEnter task number to mark as completed: ");
        string input = Console.ReadLine();

        int taskNumber;
        bool isNumber = int.TryParse(input, out taskNumber);

        if (isNumber && taskNumber >= 1 && taskNumber <= tasks.Count)
        {
            tasks[taskNumber - 1].IsCompleted = true;
            Console.WriteLine("Task completed!");
        }
        else
        {
            Console.WriteLine("Invalid number!");
        }

        Pause();
    }

    static void ViewTasks()
    {
        Console.Clear();

        Console.WriteLine("✧⋄⋆⋅⋆⋄ Your Tasks ✧⋄⋆⋅⋆⋄✧");

        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks yet.");
        }
        else
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                string status;
                if (tasks[i].IsCompleted)
                {
                    status = "[ ✔️ ]";
                }
                else
                {
                    status = "[ ]";
                }

                Console.WriteLine($"{i + 1}. {status} {tasks[i].Description}{tasks[i].DueDate.ToString(" (Due: yyyy-MM-dd)")}");
            }
        }
    }

    static void Pause()
    {
        Console.WriteLine("Press any key to return to the main menu.");
        Console.ReadKey(true);
    }

    static void Exit()
    {
        Console.Clear();
        Console.WriteLine(@"
░██████╗░██░░░░░██╗░███████╗
░██╔══██╗░██░░░██╔╝░██╔════╝
░██████╔╝░╚██░██╔╝░░█████╗░░
░██╔══██╗░░║███╔╝░░░██╔══╝░░
░██████╔╝░░║███║░░░░███████╗
░╚═════╝░░░╚═══╝░░░░╚══════╝");
        Environment.Exit(0);
    }
}