using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LibraryEFRelationship.Models
{
    public class Book
    {
        [Key]
        [Display(Name = "ID: ")]
        public int BookId{ get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }

        //One Book to Many Genres Relationship
        [ForeignKey("BookGenre")]
        public int GenreId { get; set; }
        public Genre BookGenre { get; set; }

        //Many Books to Many Authors
        public List<Author> Authors { get; set; }
    }

    public class Genre
    {
        [Key]
        [Display(Name = "ID: ")]

        public int GenreId { get; set;}
        public string Name { get; set; }

        //One Book to Many Genres Relationship
        public List<Book> Books { get; set;}
    }

    public class Author
    {
        [Key]
        [Display(Name = "ID: ")]
        public int AuthorId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        //Many Books to Many Authors
        public List<Book> Books { get; set;}
    }
}