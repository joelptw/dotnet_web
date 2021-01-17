using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnet_web.models
{
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(10, MinimumLength = 3, ErrorMessage = "ISBN must be between 10 and 3 characteres.")]
        public string Isbn { get; set; }
        [Required]
        [MaxLength(200, ErrorMessage = "Title cannot be more than 200 characteres.")]
        public string Title { get; set; }
        public DateTime? DatePublished { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<BookAuthor> BookAuthors { get; set; }
        public virtual ICollection<BookCategory> BookCategories { get; set; }

    }
}