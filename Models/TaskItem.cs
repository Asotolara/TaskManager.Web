using System.ComponentModel.DataAnnotations;
namespace TaskManager.Web.Models;
public class TaskItem
{
    public int Id{get; set;}
    [Required(ErrorMessage ="Please enter a title")]
    
    public required string Title{get; set;}
    public bool IsCompleted{get; set;}
    public DateTime? DueDate{ get; set;}
}