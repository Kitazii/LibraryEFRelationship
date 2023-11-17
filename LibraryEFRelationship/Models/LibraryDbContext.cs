using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LibraryEFRelationship.Models
{
    public class LibraryDbContext:DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Author> Authors { get; set; }

        public LibraryDbContext() : base("LibraryConnection")
        {
            Database.SetInitializer<LibraryDbContext>(new DropCreateDatabaseIfModelChanges<LibraryDbContext>());
        }
    }
}