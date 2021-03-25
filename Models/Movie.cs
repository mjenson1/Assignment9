using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment9.Models
{
    public class Movie //the movie model built with each of its attributes
    {
        [Key]
        public int MovieID { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Year { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Rating { get; set; }
        public string LentTo { get; set; }
        public bool Edited { get; set; }
        public string Notes { get; set; }
    }
}
