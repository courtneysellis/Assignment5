using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models
{
    public class EFBookstoreRepository : IBookstoreRepository //The implementation of the IBookstoreRepository Template
    {
        private BookstoreDbContext _context;

        public EFBookstoreRepository(BookstoreDbContext context) //The constructor
        {
            _context = context;
        }

        public IQueryable<Book> Books => _context.Books;
    }
}
