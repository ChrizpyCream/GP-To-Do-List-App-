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


//// Refactored code sample 

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
        // Act
        var task = CreateTask();

        // Assert
        Assert.That(task.Description, Is.EqualTo(DefaultDescription));
    }

    [Test]
    public void Constructor_SetsDueDate()
    {
        // Arrange
        var dueDate = new DateTime(2026, 3, 1);

        // Act
        var task = CreateTask(dueDate: dueDate);

        // Assert
        Assert.That(task.DueDate, Is.EqualTo(dueDate));
    }

    [Test]
    public void NewTask_IsNotCompletedByDefault()
    {
        // Act
        var task = CreateTask();

        // Assert
        Assert.That(task.IsCompleted, Is.False);
    }

    [Test]
    public void IsCompleted_CanBeSetToTrue()
    {
        // Arrange
        var task = CreateTask();

        // Act
        task.IsCompleted = true;

        // Assert
        Assert.That(task.IsCompleted, Is.True);
    }
}
