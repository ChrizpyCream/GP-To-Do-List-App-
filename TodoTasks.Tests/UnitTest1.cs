using NUnit.Framework;
using System;

namespace TodoTask.Tests
{
    public class TodoTaskTests
    {
        [Test]
        public void Constructor_SetsDescription()
        {
            // Arrange
            string description = "Finish assignment";
            DateTime dueDate = new DateTime(2026, 2, 10);

            // Act
            TodoTask task = new TodoTask(description, dueDate);

            // Assert
            Assert.AreEqual(description, task.Description);
        }

        [Test]
        public void Constructor_SetsDueDate()
        {
            DateTime dueDate = new DateTime(2026, 3, 1);

            TodoTask task = new TodoTask("Study for exam", dueDate);

            Assert.AreEqual(dueDate, task.DueDate);
        }

        [Test]
        public void NewTask_IsNotCompletedByDefault()
        {
            TodoTask task = new TodoTask("Write paper", DateTime.Now);

            Assert.IsFalse(task.IsCompleted);
        }

        [Test]
        public void IsCompleted_CanBeSetToTrue()
        {
            TodoTask task = new TodoTask("Submit project", DateTime.Now);

            task.IsCompleted = true;

            Assert.IsTrue(task.IsCompleted);
        }
    }
}


