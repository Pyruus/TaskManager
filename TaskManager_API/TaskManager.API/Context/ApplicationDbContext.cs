using Microsoft.EntityFrameworkCore;
using TaskManager_API.Model;

namespace TaskManager_API.Context;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    public DbSet<TaskItem> Tasks { get; set; }
}