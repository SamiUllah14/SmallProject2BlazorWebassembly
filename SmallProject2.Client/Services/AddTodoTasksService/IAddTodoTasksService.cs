using SmallProject2.Client.Models; // Assuming TodoItem is defined here
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmallProject2.Client.Services
{
    public interface IAddTodoTasksService
    {
        Task<List<TodoItem>> GetTodoItemsAsync();
        Task AddTodoItemsAsync(TodoItem item);
        Task DeleteTodoItemAsync(int id); // New method declaration
        Task UpdateTodoItemAsync(TodoItem item); // New method declaration


    }
}
