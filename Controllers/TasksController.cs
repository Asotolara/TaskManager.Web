using TaskManager.Web.Models;
using Microsoft.AspNetCore.Mvc;
using TaskManager.Web.Data;
using Microsoft.Extensions.Validation;
using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

[Authorize]
public class TasksController : Controller
{

    private readonly AppDbContext _context;

    public TasksController(AppDbContext context)
    {
        _context = context;
    }
    public IActionResult Index()
    {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        var tasks = _context.Tasks.Where(t => t.OwnerId == userId).ToList();
        return View(tasks);
    }

[HttpGet]
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
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        task.OwnerId = userId;
        _context.Tasks.Add(task);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
    
    [HttpGet]
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

    [HttpGet]
    public IActionResult Delete(int id)
    {
        var task = _context.Tasks.Find(id);
        if(task is null)
        {
            return NotFound();
        }

        return View(task);
    }
    [HttpPost, ActionName("Delete")]
    public IActionResult DeleteConfirmed(int id)
    {
        var task = _context.Tasks.Find(id);
        if(task is null)
        {
            return NotFound();
        }

        _context.Tasks.Remove(task);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
}