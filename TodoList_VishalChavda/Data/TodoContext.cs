using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoList_VishalChavda.Models;
using Microsoft.EntityFrameworkCore;

namespace TodoList_VishalChavda.Data
{
    public class TodoContext: DbContext
    {
        public DbSet<Todo> Todos { get; set; }

        public TodoContext(DbContextOptions<TodoContext> options)
           : base(options)
        {
        }
    }
}