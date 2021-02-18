using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models
{
    public class Book //Add comments
    {
        [Key] [Required]
        public int BookId { get; set; }
        
        [RegularExpression(@"[0-9]{3}-[0-9]{10}]$")] [Required]
        public string ISBN { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string AuthorFirstName { get; set; }

        [Required]
        public string AuthorLastName { get; set; }

        [Required]
        public string Classification { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public string Publisher { get; set; }

        [Required]
        public double Price { get; set; }
    }
}
