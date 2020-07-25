using System;
using System.ComponentModel.DataAnnotations;

namespace ToDoTest.Models
{
    public class ToDoModel
    {
        public int Id { get; set; }

        public ApplicationUser UserAcct { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        [StringLength(150)]
        [Display(Name = "What do I need to do?")]
        public string ToDo { get; set; }

        [Required]
        [Display(Name = "When does it need to be done?")]
        public DateTime DueDate { get; set; }
    }
}