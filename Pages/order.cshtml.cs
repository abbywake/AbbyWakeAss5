using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbbyWakeAss5.Infrastructure;
using AbbyWakeAss5.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
//razor page 
namespace AbbyWakeAss5.Pages
{
    public class orderModel : PageModel
    {

        private IBookRepository repository;

        //constructor
        public orderModel (IBookRepository repo, Cart cartservice)
        {
            repository = repo;
            Cart = cartservice;
        }
        //properties
        public Cart Cart { get; set; }

        public string ReturnUrl { get; set; }

        //methods
        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
            //Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
        }

        //public IActionResult OnPost(long BookId, string returnUrl)
        //{
        //    Books books = repository.Books.FirstOrDefault(p => p.BookID == BookId);

        //    Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();

        //    Cart.AddItem(books, 1);

        //    HttpContext.Session.SetJson("cart", Cart);


        //    return RedirectToPage(new { returnUrl = returnUrl });
        //}

        public IActionResult OnPost(long bookID, string returnUrl)
        {
            Books book = repository.Books
                .FirstOrDefault(p => p.BookID == bookID);
            Cart.AddItem(book, 1);
            return RedirectToPage(new { returnUrl = returnUrl });
        }

        public IActionResult OnPostRemove(long bookId, string returnUrl)
        {
            Cart.RemoveLine(Cart.Lines.First(cl =>
                cl.Books.BookID == bookId).Books);
            return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
}
