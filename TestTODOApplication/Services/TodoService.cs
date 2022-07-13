using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTODOApplication.Models;
using TestTODOApplication.Repositories;

namespace TestTODOApplication.Services
{
    public class TodoService : ITodoService
    {
        private ITodoRepository TodoRepository { get; set; }

        public TodoService(ITodoRepository todoRepository)
        {
            TodoRepository = todoRepository;
        }

        public TodoModel CreateTodo(TodoModel model)
        {
            return TodoRepository.Create(model);
        }

        public int DeleteTodo(int id)
        {
            TodoRepository.Delete(id);
            return id;
        }

        public TodoModel GetTodo(int id)
        {
            return TodoRepository.Get(id);
        }

        public List<TodoModel> GetTodos()
        {
            return TodoRepository.GetAll();
        }

        public TodoModel UpdateTodo(int id, TodoModel newModel)
        {
            newModel.Id = id;
            return TodoRepository.Update(newModel);
        }
    }
}
