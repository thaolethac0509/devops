using backend.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace backend
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options) { }

        public DbSet<TodoItem> Todos { get; set; }
    }
}
