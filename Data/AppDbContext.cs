using Microsoft.EntityFrameworkCore;
using TaskManager.Web.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace TaskManager.Web.Data
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {}

        public DbSet<TaskItem> Tasks {get; set;}
    }
}