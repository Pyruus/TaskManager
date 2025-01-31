using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManager_API.Model;

[Table("Tasks")]
public class TaskItem
{
    [Key] public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int Status { get; set; }
    public Guid? AssignedTo { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
}