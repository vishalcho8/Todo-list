using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TodoList_VishalChavda.Data;
using TodoList_VishalChavda.Models;

namespace TodoList_VishalChavda.Pages.Admin.Todos
{
    public class IndexModel : PageModel
    {
        private readonly TodoList_VishalChavda.Data.TodoContext _context;

        public IndexModel(TodoList_VishalChavda.Data.TodoContext context)
        {
            _context = context;
        }

        public IList<Todo> Todo { get;set; }

        public async Task OnGetAsync()
        {
            Todo = await _context.Todos.ToListAsync();
        }
    }
}
