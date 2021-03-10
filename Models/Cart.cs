using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookstore.Models
{
    public class Cart
    {
        public List<CartLine> Lines { get; set; } = new List<CartLine>();

        public virtual void AddItem(Book bk, int qty)
        {
            CartLine line = Lines
                .Where(p => p.Book.BookId == bk.BookId)
                .FirstOrDefault();
            if (line == null)
            {
                Lines.Add(new CartLine
                {
                    Book = bk,
                    Quantity = qty
                });
            }
            else
            {
                line.Quantity += qty;
            }
        }

        public virtual void RemoveLine(Book bk) =>
            Lines.RemoveAll(x => x.Book.BookId == bk.BookId);

        public virtual void Clear() => Lines.Clear();

        public virtual decimal ComputeTotalSum() //Book Price * Quantity
        {
            decimal sum = 0;
            foreach (CartLine line in Lines)
            {
                sum += (line.Book.Price * line.Quantity);
            }
            //Lines.Sum(e => bk.Price * e.Quantity);

            return sum;
        }

        public class CartLine
        {
            public int CartLineID { get; set; }
            public Book Book { get; set; }
            public int Quantity { get; set; }
        }
    }
}
