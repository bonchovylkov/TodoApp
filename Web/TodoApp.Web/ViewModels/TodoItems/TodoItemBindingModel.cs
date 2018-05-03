namespace TodoApp.Web.ViewModels.TodoItems
{
    using System.ComponentModel.DataAnnotations;

    using TodoApp.Common.Mapping;
    using TodoApp.Data.Models;

    public class TodoItemBindingModel : IMapTo<TodoItem>
    {
        [Required]
        public string Title { get; set; }
    }
}
