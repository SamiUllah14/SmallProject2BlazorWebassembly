using Microsoft.EntityFrameworkCore;
using SmallProject2.Server.Models; // Assuming TodoItem is defined here

namespace SmallProject2.Server.Services.AddTodoTasksService
{
    public class AddTodoTasksService : IAddTodoTasksService
    {
        private readonly DatabaseContext _context;

        public AddTodoTasksService(DatabaseContext context)
        {
            _context = context;
        }



        public async Task AddtTodoItemsAsync(TodoItem item)
        {
            _context.TodoItems.Add(item);
            await _context.SaveChangesAsync();
                }

        public async Task DeleteTodoItemAsync(int id)
        {
            var todoItem = await _context.TodoItems.FindAsync(id);
            if (todoItem != null)
            {
                _context.TodoItems.Remove(todoItem);
                await _context.SaveChangesAsync();
            }
        }
        public async Task<List<TodoItem>> GetTodoItemsAsync()
        {
            return await _context.TodoItems.ToListAsync();
        }

        public async Task UpdateTodoItemAsync(TodoItem item) 
        { 
        _context.TodoItems.Update(item); 
            await _context.SaveChangesAsync();
}
    }
}
