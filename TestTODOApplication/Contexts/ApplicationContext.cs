using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTODOApplication.Models;

namespace TestTODOApplication.Contexts
{
    public class ApplicationContext : DbContext
    {
        public DbSet<TodoModel> Todos { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
