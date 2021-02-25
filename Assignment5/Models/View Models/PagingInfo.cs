using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models
{
    //Gets the amount of pages the site will have based on total items and the number of items wanted on each page
    public class PagingInfo
    {
        public int TotalNumItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }

        public int TotalPages => (int)Math.Ceiling((decimal)TotalNumItems / ItemsPerPage);

    }
}
