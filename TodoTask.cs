public class TodoTask
{
    public string Description;
    public bool IsCompleted;
    
    public TodoTask(string description)
    {
        Description = description;
        IsCompleted = false;
    }
}