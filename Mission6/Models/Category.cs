using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6.Models
{
    public class Category
    {
        [Key] // assigning categoryid as the key 
        [Required]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
