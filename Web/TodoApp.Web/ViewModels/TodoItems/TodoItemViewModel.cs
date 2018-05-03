namespace TodoApp.Web.ViewModels.TodoItems
{
    using TodoApp.Common.Mapping;
    using TodoApp.Data.Models;

    public class TodoItemViewModel : IMapFrom<TodoItem>
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public bool IsDone { get; set; }
    }
}
