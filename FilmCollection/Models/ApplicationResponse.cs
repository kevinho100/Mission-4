using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

 
namespace FilmCollection.Models
{
    public class ApplicationResponse
    {
        [Key]
        [Required]
        public int MovieID { get; set; }

        [Required]
        public string Category { get; set; }
        //public Categories<SelectListItem> Categories { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public string Director { get; set; }

        [Required]
        public string Rating { get; set; }
        //public Ratings<SelectListItem> Ratings { get; set; }

        public bool Edited { get; set; }

        public string LenTo { get; set; }

        [StringLength(25)]
        public string Notes { get; set; }
    }
}
