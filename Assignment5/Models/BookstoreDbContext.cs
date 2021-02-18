using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models
{
    public class BookstoreDbContext : DbContext //A session with the database, used to query and save instances of objects
                                                //CharityDbContext is a specific instance of a DbContext. How we do CRUD
    {
        public BookstoreDbContext(DbContextOptions<BookstoreDbContext> options) : base (options)
        {

        }        
        public DbSet<Book> Books { get; set; }
    }
}
