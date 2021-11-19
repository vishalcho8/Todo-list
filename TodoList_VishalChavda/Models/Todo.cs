using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TodoList_VishalChavda.Models
{
    public class Todo
    {
        [Key]
        public int TodoId { get; set; }

        [StringLength(20, MinimumLength = 6)]
        public string Title { get; set; }

        public string Description { get; set; }

        public bool IsDone { get; set; } = false;

        public DateTime CompletionDate { get; set; }


    }
}
