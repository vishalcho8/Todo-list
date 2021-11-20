using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TodoList_VishalChavda.Models
{
    /*
     * Creating simple POCO class.
     * This class will act as a model and be used to create table in the database.
     */
    public class Todo
    {

        [Key] /* Will generate primary key on TodoId column in table.*/
        public int TodoId { get; set; }

        [Required] /* Title field is mandatory. It can't be empty*/
        [StringLength(20, MinimumLength = 6)] /* TItle cannot be less than 6 chars and more than 20 chars. */
        public string Title { get; set; }

        public string Description { get; set; }

        [Display(Name = "Done")]    /* On view page field will be created with label "Done" */
        public bool IsDone { get; set; } = false;

        [Display(Name ="Completion Date")]  /* On view page field will be created with label "Completion Date" */
        public DateTime? CompletionDate { get; set; } /*Copletetion date field is optional, it can be empty*/


    }
}
