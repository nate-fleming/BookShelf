using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookShelf.Models
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string Firstname { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [NotMapped]
        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return $"{Firstname} {LastName}";
            }
        }

        public string Penname { get; set; }

        [Display(Name = "Preferred Genre")]
        public string PreferredGenre { get; set; }

        public virtual ICollection<Book> Books { get; set; }

        public ApplicationUser CreatedBy { get; set; }
    }
}
