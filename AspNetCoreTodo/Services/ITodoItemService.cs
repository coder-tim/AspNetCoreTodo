using System.Threading.Tasks;
using AspNetCoreTodo.Models;
using System;
public interface ITodoItemService
{
    Task<TodoItem[]> GetIncompleteItemsAsync();

    Task<bool> AddItemAsync(TodoItem newItem);

    Task<bool> MarkDoneAsync(Guid id);
}