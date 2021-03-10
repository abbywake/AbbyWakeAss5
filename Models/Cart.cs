using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbbyWakeAss5.Models
{
    public class Cart
    {
        //making a list of cartlines. 
        public List<CartLine> Lines { get; set; } = new List<CartLine>();

        //this adds an item to the cart 
        public virtual void AddItem(Books boo, int quantity)
        {
            CartLine line = Lines.Where(p => p.Books.BookID == boo.BookID)
                .FirstOrDefault();

            if (line == null)
            {
                Lines.Add(new CartLine
                {
                    Books = boo,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }
        //removes a line
        public virtual void RemoveLine(Books boo) =>
            Lines.RemoveAll(x => x.Books.BookID == boo.BookID);

        //this isn't impemented anywhere, but it clears all of them 
        public virtual void Clear() => Lines.Clear();
        //computing the sum for all of it 
        public decimal ComputeTotalSum() => (decimal)Lines.Sum(e => e.Books.Price * e.Quantity);
       

        //cartline class 
        public class CartLine
        {
            public int CartLineID { get; set; }
            public Books Books { get; set; }

            public int Quantity { get; set; }
        }
        


    }
}
