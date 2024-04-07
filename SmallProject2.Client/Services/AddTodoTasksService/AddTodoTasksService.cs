using SmallProject2.Client.Models; // Assuming TodoItem is defined here
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace SmallProject2.Client.Services
{
    public class AddTodoTasksService : IAddTodoTasksService
    {
        private readonly HttpClient _httpClient;

        public AddTodoTasksService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task AddTodoItemsAsync(TodoItem item)
        {
            await _httpClient.PostAsJsonAsync("api/todo/add", item);
        }

        public async Task DeleteTodoItemAsync(int id) // Implement delete method
        {
            await _httpClient.DeleteAsync($"api/todo/delete/{id}");
        }

        public async Task<List<TodoItem>> GetTodoItemsAsync()
        {
            var todoItemsResponse = await _httpClient.GetFromJsonAsync<List<TodoItem>>("api/todo/all");
            return todoItemsResponse ?? new List<TodoItem>();
        }

        public async Task UpdateTodoItemAsync(TodoItem item)
        {
            await _httpClient.PutAsJsonAsync($"api/todo/update/{item.Id}", item);
        }
    }
}
