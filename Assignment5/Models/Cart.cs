using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models
{
    //Creatiing a list of CartLines in the cart to hold each item in the cart with the functions that make the cart work
    public class Cart
    {
        public List<CartLine> Lines { get; set; } = new List<CartLine>();

        public virtual void AddItem(Book b, int qty)
        {
            //Look to see if the project ID exists in the list and compare that to the project ID passed in to see if there's a match
            CartLine line = Lines.
                Where(x => x.Book.BookId == b.BookId).
                FirstOrDefault();

            //If it's not there, then add it to the list. If it is, just update the quantity
            if (line == null)
            {
                Lines.Add(new CartLine
                {
                    Book = b,
                    Quantity = qty
                });
            }
            else
            {
                line.Quantity += qty;
            }
        }

        //Remove from the line using a specific projectID
        public virtual void RemoveLine(Book b) =>
            Lines.RemoveAll(x => x.Book.BookId == b.BookId);

        //Clears everything from the line list (cart)
        public virtual void Clear() => Lines.Clear();

        //Get the sum of the cart
        public decimal ComputeTotalSum() =>
            (decimal)Lines.Sum(e => e.Book.Price * e.Quantity);


        //Container to hold the information for the cart
        public class CartLine
        {
            public int CartLineID { get; set; }
            public Book Book { get; set; }
            public int Quantity { get; set; }
        }
    }
}
