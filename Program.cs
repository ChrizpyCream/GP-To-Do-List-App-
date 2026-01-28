using System.Data;

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
}
