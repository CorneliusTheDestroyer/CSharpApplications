using System;

namespace TodoListManager;

public class ToDoTask
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public bool IsCompleted { get; set; }

    public ToDoTask(string title)
    {
        Id = Guid.NewGuid();
        Title = title;
        IsCompleted = false;
    }

    public override string ToString()
    {
        return $"[{(IsCompleted ? "X" : " ")}] - {Title}";
    }
}