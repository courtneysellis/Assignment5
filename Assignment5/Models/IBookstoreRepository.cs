using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models
{
    public interface IBookstoreRepository //Creating a template. Meant to be inherited. Like a base class
    {
        IQueryable<Book> Books { get; }
    }
}
