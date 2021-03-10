using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineBookstore.Infrastructure;
using OnlineBookstore.Models;

namespace OnlineBookstore.Pages
{
    public class BuyModel : PageModel
    {
        private IBookRepository repository;

        public BuyModel(IBookRepository repo)
        {
            repository = repo;
        }

        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }

        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
            Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
        }

        public IActionResult OnPost(long bookId, string returnUrl)
        {
            Book book = repository.Books.FirstOrDefault(p => p.BookId == bookId);

            Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
            Cart.AddItem(book, 1);

            HttpContext.Session.SetJson("cart", Cart);

            return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
}
