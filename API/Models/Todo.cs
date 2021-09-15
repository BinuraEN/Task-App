using System;

namespace API.Models
{
    public class Todo
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime Created { get; set; }

        public DateTime Due { get; set; }

        public TodoStatus Status { get; set; } //New, InProgress,Completed
    }

    public enum TodoStatus{
        New,
        InProgress,
        Completed
    }

}