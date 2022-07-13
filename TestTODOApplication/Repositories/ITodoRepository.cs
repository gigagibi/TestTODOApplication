using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTODOApplication.Models;

namespace TestTODOApplication.Repositories
{
    public interface ITodoRepository
    {
        public List<TodoModel> GetAll();
        public TodoModel Get(int id);
        public TodoModel Create(TodoModel model);
        public TodoModel Update(TodoModel model);
        public void Delete(int id);
    }
}
