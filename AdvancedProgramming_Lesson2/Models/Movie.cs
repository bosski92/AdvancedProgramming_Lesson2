using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedProgramming_Lesson2.Models

{
    public class Movie
    {
        [Display(Name = "ID")]
        public int Id { get; set; }
        [Display(Name = "Title")]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Release date")]
        public DateTime ReleaseDate { get; set; }
        [Display(Name = "Genre")]
        public string Genre { get; set; }
        [Display(Name = "Price")]
        public decimal Price { get; set; }

        [Display(Name = "Director")]
        public string Director { get; set; }
        [Display(Name = "Oscar")]
        public string Oscar { get; set; }

    }
}
