using System;
using System.ComponentModel.DataAnnotations;

namespace BookShelf.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }

        [Required]
        [StringLength(13, MinimumLength = 10, ErrorMessage = "Must be between 10 to 13 characters.")]
        public string ISBN { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Genre { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date Published")]
        public DateTime PublishDate { get; set; }

        public Author Author { get; set; }

        public ApplicationUser Owner { get; set; }
    }

}