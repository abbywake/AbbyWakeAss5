using AbbyWakeAss5.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AbbyWakeAss5.Models
{
    //this is mainly copied from the book but it inherits from Cart and then it does gets and makes it so we can actually do everything with the cart - remove and add. 
    public class SessionCart : Cart 
    {

        public static Cart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?
                .HttpContext.Session;
            SessionCart cart = session?.GetJson<SessionCart>("Cart")
                ?? new SessionCart();
            cart.Session = session;
            return cart;
        }

        [JsonIgnore]
        public ISession Session { get; set; }

        public override void AddItem(Books books, int quantity)
        {
            base.AddItem(books, quantity);
            Session.SetJson("Cart", this);
        }

        public override void RemoveLine(Books books)
        {
            base.RemoveLine(books);
            Session.SetJson("Cart", this);
        }

        public override void Clear()
        {
            base.Clear();
            Session.Remove("Cart");
        }
    }
}
