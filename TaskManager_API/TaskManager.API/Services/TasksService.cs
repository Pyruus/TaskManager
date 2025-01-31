using Microsoft.EntityFrameworkCore;
using TaskManager_API.Context;
using TaskManager_API.Model;

namespace TaskManager_API.Services;

public class TasksService : ITasksService
{
    private readonly ApplicationDbContext _context;

    public TasksService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<TaskItem>> GetTasks()
    {
        return await _context.Tasks.ToListAsync();
    }

    public async Task CreateTask(TaskItem task)
    {
        _context.Tasks.Add(task);
        await _context.SaveChangesAsync();
    }
}

public interface ITasksService
{
    Task<List<TaskItem>> GetTasks();
    Task CreateTask(TaskItem task);
}