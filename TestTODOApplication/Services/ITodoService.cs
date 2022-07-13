using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTODOApplication.Models;

namespace TestTODOApplication.Services
{
    public interface ITodoService
    {
        public TodoModel GetTodo(int id);
        public List<TodoModel> GetTodos();

        public TodoModel CreateTodo(TodoModel model);

        public TodoModel UpdateTodo(int id, TodoModel newModel);

        public int DeleteTodo(int id);
    }
}
