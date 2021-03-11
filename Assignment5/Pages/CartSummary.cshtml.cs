using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment5.Infrastructure;
using Assignment5.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Assignment5.Pages
{
    //Connects to the CartSummary Razor Page
    public class CartSummaryModel : PageModel
    {
        private IBookstoreRepository repository;

        //Constructor to set the repository
        public CartSummaryModel(IBookstoreRepository repo, Cart cartService)
        {
            repository = repo;
            Cart = cartService;
        }

        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }

        //Set our returnUrl to the one given, or just / if it wasnt given
        //Add the cart to the session when the page is loaded (on Get) using the GetJson method made in the SessionExtentions class
        //Or if there isn't a cart saved, make a new cart
        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
            //Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
        }

        //On post, look at repo to find the matching project. Get the cart or make a new one, then add the project to the cart
        //Then set the json to the cart with the updated info
        //The names of the parameters passed in need to be the same as the asp-for values in the cshtml they are being pulled from (not case sensitive)
        public IActionResult OnPost(long bookId, string returnUrl)
        {
            Book book = repository.Books.FirstOrDefault(b => b.BookId == bookId);

            //Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();

            Cart.AddItem(book, 1);

            //HttpContext.Session.SetJson("cart", Cart);

            return RedirectToPage(new { returnUrl = returnUrl }); //The objects returnUrl is set to the returnUrl that was passed in
        }

        public IActionResult OnPostRemove(long bookId, string returnUrl)
        {
            Cart.RemoveLine(Cart.Lines.First(x => x.Book.BookId == bookId).Book);
            return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
}
