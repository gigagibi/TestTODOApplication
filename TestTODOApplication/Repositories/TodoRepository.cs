using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTODOApplication.Contexts;
using TestTODOApplication.Exceptions;
using TestTODOApplication.Models;

namespace TestTODOApplication.Repositories
{
    public class TodoRepository : ITodoRepository
    {
        private ApplicationContext Context { get; set; }

        public TodoRepository(ApplicationContext context)
        {
            this.Context = context;
        }

        public TodoModel Create(TodoModel model)
        {
            Context.Set<TodoModel>().Add(model);
            Context.SaveChanges();
            return model;
        }

        public void Delete(int id)
        {
            var toDelete = Context.Set<TodoModel>().FirstOrDefault(m => m.Id == id);
            if(toDelete != null)
            {
                Context.Set<TodoModel>().Remove(toDelete);
                Context.SaveChanges();
            }
            else
            {
                throw new TodoModelNotFoundException();
            }
        }

        public TodoModel Get(int id)
        {
            return Context.Set<TodoModel>().FirstOrDefault(m => m.Id == id);
        }

        public List<TodoModel> GetAll()
        {
            return Context.Set<TodoModel>().ToList();
        }

        public TodoModel Update(TodoModel model)
        {
            var toUpdate = Context.Set<TodoModel>().Find(model.Id);
            
            if (toUpdate != null)
            {
                Context.Entry(toUpdate).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
                Context.Update(model);
                Context.SaveChanges();
                return Context.Set<TodoModel>().FirstOrDefault(m => m.Id == model.Id);
            }
            else
            {
                throw new TodoModelNotFoundException("Model with id = " + model.Id + "was not found");
            }
            
        }
    }
}
