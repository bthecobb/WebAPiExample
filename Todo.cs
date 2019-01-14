using System;
using Microsoft.EntityFrameworkCore;

namespace webapitest.Models
{
    public class Todo :DbContext
    {
        public Todo(DbContextOptions<Todo> options) : base(options)
        {

        }

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
