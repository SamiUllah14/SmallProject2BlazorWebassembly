using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmallProject2.Server.Models;

namespace SmallProject2.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly IAddTodoTasksService _toDoService;

        public TodoController(IAddTodoTasksService toDoService)
        {
            _toDoService = toDoService;
        }

        [HttpPost]
        [Route("Add")]

        public async Task<IActionResult> AddToDoItem(TodoItem item)
        {
            await _toDoService.AddtTodoItemsAsync(item);
            return Ok();
        }
        [HttpGet]
        [Route("all")]
        public async Task<IActionResult> GetTodoItems()
        {
            var todoItems = await _toDoService.GetTodoItemsAsync();
            return Ok(todoItems);
        }
        [HttpDelete]
        [Route("Delete/{id}")]
        public async Task<IActionResult> DeleteTodoItem(int id)
        {
            await _toDoService.DeleteTodoItemAsync(id);
            return Ok();
        }
        [HttpPut]
        [Route("Update/{id}")]
        public async Task<IActionResult> UpdateTodoItem(int id, TodoItem item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }

            await _toDoService.UpdateTodoItemAsync(item);
            return Ok();
        }
    }
}
