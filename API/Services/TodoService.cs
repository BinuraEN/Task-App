using System;
using System.Collections.Generic;
using API.Models;

namespace API.Services
{
    public class TodoService
    {
        //Get Todos
        public List<Todo> AllTodos(){
            var todos = new List<Todo>();

            var todo1 = new Todo
            {
                Id = 1,
                Title = "Get books for school",
                Description = "Get books for school from sarasavi",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.New,
            };
            todos.Add(todo1);

            var todo2 = new Todo
            {
                Id = 2,
                Title = "Get vegetables",
                Description = "Get vegs for the week",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(2),
                Status = TodoStatus.Completed,
            };
            todos.Add(todo2);

            var todo3 = new Todo
            {
                Id = 3,
                Title = "Pickup dog food",
                Description = "Get pedigree dog food for max",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(3),
                Status = TodoStatus.New,
            };
            todos.Add(todo3);

            var todo4 = new Todo
            {
                Id = 4,
                Title = "Buy Ice cream",
                Description = "Buy chocolate ice cream for the party",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(1),
                Status = TodoStatus.New,
            };
            todos.Add(todo4);

            return todos;
        }
    }
}