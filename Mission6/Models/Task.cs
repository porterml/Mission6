using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6.Models
{
    public class Task
    {
        [Key]
        [Required]
        public int TaskId { get; set; }

        public string TaskName { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")] 
        public DateTime DueDate { get; set; }

        public int Quadrant { get; set; }

        public int CategoryId { get; set; } // foreign key relationship to the 'QuadrantCategory' table 
        public Category Category { get; set; }// porter uncommented this so he could use it in the controller
        public bool Completed { get; set; }

    }
}
