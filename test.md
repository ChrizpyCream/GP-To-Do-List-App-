using NUnit.Framework;

// unit test 
public class TodoTaskTests
{
    [Test]
    public void Constructor_SetsDescription()
    {
        var task = new TodoTask("Finish assignment", new DateTime(2026, 2, 10));
        Assert.That(task.Description, Is.EqualTo("Finish assignment"));
    }

    [Test]
    public void Constructor_SetsDueDate()
    {
        var dueDate = new DateTime(2026, 3, 1);
        var task = new TodoTask("Study", dueDate);
        Assert.That(task.DueDate, Is.EqualTo(dueDate));
    }

    [Test]
    public void NewTask_IsNotCompletedByDefault()
    {
        var task = new TodoTask("Write paper", DateTime.Now);
        Assert.That(task.IsCompleted, Is.False);
    }

    [Test]
    public void IsCompleted_CanBeSetToTrue()
    {
        var task = new TodoTask("Submit project", DateTime.Now);
        task.IsCompleted = true;
        Assert.That(task.IsCompleted, Is.True);
    }
}