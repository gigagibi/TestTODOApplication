using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTODOApplication.Exceptions;
using TestTODOApplication.Models;
using TestTODOApplication.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestTODOApplication.Controllers
{
    [Route("api/todos")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private ITodoService TodoService { get; set; }

        public TodosController(ITodoService todoService)
        {
            TodoService = todoService;
        }

        // GET: api/<ValuesController>
        [HttpGet]
        public IActionResult GetTodos()
        {
            return Ok(TodoService.GetTodos());
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}", Name = "GetTodo")]
        public IActionResult GetTodo(int id)
        {
            return Ok(TodoService.GetTodo(id));
        }

        // POST api/<ValuesController>
        [HttpPost]
        public IActionResult CreateTodo([FromBody] TodoModel todo)
        {
            
            return CreatedAtAction(nameof(GetTodo), new { id = todo.Id }, TodoService.CreateTodo(todo));
        }
        
        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public IActionResult UpdateTodo(int id, [FromBody] TodoModel todo)
        {
            try
            {
                TodoModel updatedTodo = TodoService.UpdateTodo(id, todo);
                return Ok(updatedTodo);
            }
            catch (TodoModelNotFoundException)
            {
                return BadRequest();
            }
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public IActionResult DeleteTodo(int id)
        {   
            try
            {
                return Ok(TodoService.DeleteTodo(id));
            }
            catch (TodoModelNotFoundException)
            {
                return BadRequest();
            }
        }
    }
}
