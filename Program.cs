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
    static List<TodoTask> tasks = new List<ThreadPool>();
    static void Main()
    {

        Menu menu = new Menu();
        menu.ShowWelcomeMessage();

        if (true)
        {
            Console.Clear();
            menu.ShowMainMenu();
        }
    }
//>>>>>>> 5c4ba5c13b84fc9b2dd5f57a0f67dcd9d823446f
}
