using System.ComponentModel.DataAnnotations;

namespace SmallProject2.Server.Models
{
    public class TodoItem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string TaskName { get; set; } = string.Empty;

        public bool IsCompleted { get; set; }


        // Additional properties such as DueDate, Priority, etc., can be added as needed
    }
}
