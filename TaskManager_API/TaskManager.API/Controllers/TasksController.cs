using Microsoft.AspNetCore.Mvc;
using TaskManager_API.Model;
using TaskManager_API.Services;

namespace TaskManager_API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TasksController : ControllerBase
{
    private readonly ITasksService _tasksService;

    public TasksController(ITasksService tasksService)
    {
        _tasksService = tasksService;
    }
    
    [HttpGet]
    public async Task<IActionResult> GetTasks()
    {
        return Ok(await _tasksService.GetTasks());
    }

    [HttpPost]
    public async Task<IActionResult> CreateTask(TaskItem task)
    {
        await _tasksService.CreateTask(task);
        return Created();
    }
}