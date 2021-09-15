using System;
using System.Collections.Generic;
using System.Linq;
using API.Models;
using API.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{   
    [ApiController]
    [Route("api/[controller]")]
    public class TodosController : ControllerBase
    {
        private TodoService _todoService;

        public TodosController(TodoService todoService)
        {
            _todoService = todoService;
        }
        //seperation of concerns
        [HttpGet("{id?}")]
        public IActionResult GetTodo(int? id)
        {
            var myTodos = _todoService.AllTodos();

            if(id is null) return Ok(myTodos);

            myTodos = myTodos.Where(t => t.Id == id).ToList();

            return Ok(myTodos);
        }
        
        


    }
}