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
    public class DetailsModel : PageModel
    {
        private readonly TodoList_VishalChavda.Data.TodoContext _context;

        public DetailsModel(TodoList_VishalChavda.Data.TodoContext context)
        {
            _context = context;
        }

        public Todo Todo { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Todo = await _context.Todos.FirstOrDefaultAsync(m => m.TodoId == id);

            if (Todo == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
