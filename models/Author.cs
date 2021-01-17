using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnet_web.models
{
    public class Author
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "First name cannot be more than 100 characteres.")]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(200, ErrorMessage = "Last name cannot be more than 200 characteres.")]
        public string LastName { get; set; }
        public Country Country { get; set; }
        public virtual ICollection<BookAuthor> BookAuthors { get; set; }

    }
}