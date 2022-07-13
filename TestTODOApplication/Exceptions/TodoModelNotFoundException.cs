using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestTODOApplication.Exceptions
{
    public class TodoModelNotFoundException : Exception
    {
        public TodoModelNotFoundException()
        {
        }

        public TodoModelNotFoundException(string message) : base(message)
        {
        }

        public TodoModelNotFoundException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
