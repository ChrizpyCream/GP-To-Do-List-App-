

using NUnit.Framework;
using TodoApp;
using System;

public class TodoTaskTests
{
    private const string DefaultDescription = "Finish assignment";
    private static readonly DateTime DefaultDueDate =
        new DateTime(2026, 2, 10);

    private TodoTask CreateTask(
        string description = DefaultDescription,
        DateTime? dueDate = null)
    {
        return new TodoTask(
            description,
            dueDate ?? DefaultDueDate
        );
    }

    [Test]
    public void Constructor_SetsDescription()
    {
        
        var task = CreateTask();

        
        Assert.That(task.Description, Is.EqualTo(DefaultDescription));
    }

    [Test]
    public void Constructor_SetsDueDate()
    {
       
        var dueDate = new DateTime(2026, 3, 1);

        
        var task = CreateTask(dueDate: dueDate);

        
        Assert.That(task.DueDate, Is.EqualTo(dueDate));
    }

    [Test]
    public void NewTask_IsNotCompletedByDefault()
    {
        
        var task = CreateTask();

        
        Assert.That(task.IsCompleted, Is.False);
    }

    [Test]
    public void IsCompleted_CanBeSetToTrue()
    {
    
        var task = CreateTask();

        task.IsCompleted = true;
        
        Assert.That(task.IsCompleted, Is.True);
    }
}
