using Microsoft.EntityFrameworkCore;
using TaskManager.Web.Models;

namespace TaskManager.Web.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {}

        public DbSet<TaskItem> Tasks {get; set;}
    }
}