using SmallProject2.Server.Models;

namespace SmallProject2.Server.Services.AddTodoTasksService
{
    public interface IAddTodoTasksService
    {
        Task<List<TodoItem>> GetTodoItemsAsync();
        Task AddtTodoItemsAsync(TodoItem item);

        Task DeleteTodoItemAsync(int id); // New method to delete a task
        Task UpdateTodoItemAsync(TodoItem item); // New method to update a todo item




    }
}
