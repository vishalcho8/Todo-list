using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoList_VishalChavda.Data;
using TodoList_VishalChavda.Models;

namespace TodoList_VishalChavda.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        private readonly TodoContext db;

        [FromForm]
        public Todo Todo { get; set; }

        public List<Todo> TodoList { get; set; }

        public IndexModel(ILogger<IndexModel> logger, TodoContext dbContext)
        {
            _logger = logger;
            db = dbContext;
        }

        public void OnGet()
        {
            var query = db.Todos;
            TodoList = query.ToList();

        }

        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                db.Todos.Add(Todo);
                db.SaveChanges();
            }

            TodoList = db.Todos.ToList();
        }
    }
}
