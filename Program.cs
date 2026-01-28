using System;
using System.Collections.Generic;

namespace TodoApp
{
    class Program
    {
        static List<TodoTask> tasks = new List<TodoTask>();

        static void Main()
        {
            Menu menu = new Menu();
            menu.ShowWelcomeMessage();

            while (true)
            {
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. Remove Task");
                Console.WriteLine("3. Mark Task Complete");
                Console.WriteLine("4. View Tasks");
                Console.WriteLine("5. Exit");

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
