public class Menu
{
    public void ShowWelcomeMessage()
    {
        Console.Clear();
        System.Console.WriteLine(@"
───▄▀▀▀▄▄▄▄▄▄▄▀▀▀▄───
───█▒▒░░░░░░░░░▒▒█───
────█░░█░░░░░█░░█────
─▄▄──█░░░▀█▀░░░█──▄▄─
█░░█─▀▄░░░░░░░▄▀─█░░█
█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
█░░╦─╦╔╗╦─╔╗╔╗╔╦╗╔╗░░█
█░░║║║╠─║─║─║║║║║╠─░░█
█░░╚╩╝╚╝╚╝╚╝╚╝╩─╩╚╝░░█");
        System.Console.WriteLine("to To-Do List!");
        System.Console.WriteLine("Please press any key to continue...");
        Console.ReadKey(true);
    }

    public void ShowMainMenu()
    {
        System.Console.WriteLine("✧⋄⋆⋅⋆⋄✧⋄⋆⋅⋆⋄✧⋄⋆⋅⋆⋄✧⋄⋆⋅⋆⋄✧⋄⋆⋅⋆⋄✧⋄⋆⋅⋆⋄✧⋄⋆⋅⋆⋄✧");
        System.Console.WriteLine("⋄ Please enter the number of your choice: ⋄");
        System.Console.WriteLine("⋆    1. Add a new task                    ⋆");
        System.Console.WriteLine("⋅    2. Remove a task.                    ⋅");
        System.Console.WriteLine("⋅    3. View all tasks.                   ⋅");
        System.Console.WriteLine("⋆    4. Marked task as completed.         ⋆");
        System.Console.WriteLine("⋄    5. Exit.                             ⋄");
        System.Console.WriteLine("✧⋄⋆⋅⋆⋄✧⋄⋆⋅⋆⋄✧⋄⋆⋅⋆⋄✧⋄⋆⋅⋆⋄✧⋄⋆⋅⋆⋄✧⋄⋆⋅⋆⋄✧⋄⋆⋅⋆⋄✧");
    }
}