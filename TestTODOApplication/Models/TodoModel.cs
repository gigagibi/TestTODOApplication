using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestTODOApplication.Models
{
    public class TodoModel
    {
        public int Id { get; set; }
        public string Writer { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }
}
