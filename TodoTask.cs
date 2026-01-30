namespace TodoApp
{
    public class TodoTask
    {
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime DueDate { get; set; }

        public TodoTask(string Description)
        {
            Description = Description;
            IsCompleted = false;
            DueDate = DueDate;
        }
    }
}