using TaskManager.Web.Models;
using Microsoft.AspNetCore.Mvc;
using TaskManager.Web.Data;
using Microsoft.Extensions.Validation;
using System.Reflection.Metadata.Ecma335;

public class TasksController : Controller
{

    private readonly AppDbContext _context;

    public TasksController(AppDbContext context)
    {
        _context = context;
    }
    public IActionResult Index()
    {
        var tasks = _context.Tasks.ToList();
        return View(tasks);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(TaskItem task)
    {
        if (!ModelState.IsValid)
        {
            return View(task);
        }
        _context.Tasks.Add(task);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
    
    public IActionResult Edit(int id)
    {
        var task = _context.Tasks.Find(id);
        if(task is null)
        {
            return NotFound();
        }
        
        
        return View(task);
    }
    [HttpPost]
    public IActionResult Edit(TaskItem task)
    {
        if (!ModelState.IsValid)
        {
            return View(task);
        }

        _context.Tasks.Update(task);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
}