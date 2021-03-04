using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models.View_Models
{
    public class BookListViewModel
    {
        //Holds the data we need for each specific view that uses Book info
            public IEnumerable<Book> Books{ get; set; }
            public PagingInfo PagingInfo { get; set; }
            public string CurrentCategory { get; set; }
    }
}
