using Microsoft.AspNetCore.Mvc;
using AbbyWakeAss5.Models;
namespace AbbyWakeAss5.Components

    //inherents from the ViewComponent and sets the cart to the cartservice which is used later. and then they view the cart with the link
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private Cart cart;
        public CartSummaryViewComponent(Cart cartService)
        {
            cart = cartService;
        }
        public IViewComponentResult Invoke()
        {
            return View(cart);
        }
    }
}

