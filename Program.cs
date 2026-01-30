using System;
using System.Collections.Generic;

namespace TodoApp
{
    class Program
    {
        static List<TodoTask> tasks = new List<TodoTask>();

//<<<<<<< HEAD
        static void Main()
        {   //adding the menu from Menu.cs testing 
            Menu menu = new Menu();
            menu.ShowWelcomeMessage();

            while (true)
            {
               Console.WriteLine("Please enter the number of your choice:" + "\n");
        Console.WriteLine("✧⋄⋆⋅⋆⋄✧⋄⋆⋅⋆⋄✧✧⋄⋆⋅⋆⋄✧⋄⋆⋅⋆⋄✧✧⋄⋆⋅⋆⋄✧✧⋄⋆⋅⋆⋄✧");
        Console.WriteLine("⋄    1. Add a new task                   ⋄");
        Console.WriteLine("⋆    2. Remove a task.                   ⋆");
        Console.WriteLine("⋅    4. Marked task as completed.         ⋅");
        Console.WriteLine("⋆    3. View all tasks.                  ⋆");
        Console.WriteLine("⋄    5. Exit.                            ⋄");
        Console.WriteLine("✧⋄⋆⋅⋆⋄✧⋄⋆⋅⋆⋄✧✧⋄⋆⋅⋆⋄✧⋄⋆⋅⋆⋄✧");

                string choice = Console.ReadLine();

               // if (choice == "1") AddTask();                 //
               // else if (choice == "2") RemoveTask();   //
               // else if (choice == "3") CompleteTask();//
               // else if (choice == "4") DisplayTasks();//
               // else if (choice == "5") break;//
            }
        }

        
    }
}
//=======
class program
{
    static List<TodoTask> tasks = new List<TodoTask>();
    static void Main()
    {

        Menu menu = new Menu();
        menu.ShowWelcomeMessage();

        bool running = true;

        while (true)
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
                    Console.WriteLine("\nPress any key");
                    Console.ReadKey();
                    break;

                case "4":
                    MarkTaskCompleted();
                    break;

                case "5":
                    running = false;
                    Console.WriteLine("\nBye");
                    break;

                default:
                    Console.WriteLine("\nPlease enter a number between 1 and 5.");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    break;

                    static void AddTask()
                    {
                        Console.WriteLine("\n--- Add New Task ---");
                        Console.Write("What do you need to do? ");
                        string taskDescription = Console.ReadLine();

                        if (taskDescription != "")
                        {
                            TodoTask newTask = new TodoTask(taskDescription);
                            tasks.Add(newTask);
                            Console.WriteLine("Task added");
                        }
                            

                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                    }

                    static void RemoveTask()
                    {
                        if (tasks.Count == 0)
                        {
                            Console.WriteLine("\nNo tasks to remove");
                            Console.WriteLine("Press any key to continue");
                            Console.ReadKey();
                            return;
                        }

                        ViewTasks();
                        Console.Write("\nEnter task number to remove: ");
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
                            Console.WriteLine("Invalid number");
                        }

                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                    }

                    static void ViewTasks()
                    {
                        Console.WriteLine("\n--- Your Tasks ---");

                        if (tasks.Count == 0)
                        {
                            Console.WriteLine("No tasks yet");
                            return;
                        }

                        for (int i = 0; i < tasks.Count; i++)
                        {
                            string status;
                            if (tasks[i].IsCompleted)
                            {
                                status = "[✔️]";  
                            }
                            else
                            {
                                status = "[ ]";  
                            }

                            Console.WriteLine($"{i + 1}. {status} {tasks[i].Description}");
                        }
                    }

                    static void MarkTaskCompleted()
                    {
                        if (tasks.Count == 0)
                        {
                            Console.WriteLine("\nNo tasks completed");
                            Console.WriteLine("Press any key to continue");
                            Console.ReadKey();
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
                            Console.WriteLine("Task completed");
                        }
                        else
                        {
                            Console.WriteLine("Invalid number");
                        }

                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                    }
            }
        }

    }
//>>>>>>> 5c4ba5c13b84fc9b2dd5f57a0f67dcd9d823446f
}
