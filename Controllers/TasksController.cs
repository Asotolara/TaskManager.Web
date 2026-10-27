using TaskManager.Web.Models;
using Microsoft.AspNetCore.Mvc;

public class TasksController : Controller
{
    public IActionResult Index()
    {
        var tasks = new List<TaskItem>
        {
            new TaskItem{ Id = 1, Title = "Finish Report", IsCompleted = false, DueDate = DateTime.Now.AddDays(1)},
            new TaskItem{ Id = 2, Title = "Buy Groceries", IsCompleted = true, DueDate = DateTime.Now.AddDays(2)},
            new TaskItem{ Id = 3, Title = "Clean my room", IsCompleted = false, DueDate = DateTime.Now.AddDays(3)}
        };

        return View(tasks);
    }
}