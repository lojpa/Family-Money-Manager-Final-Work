using System.Collections.Generic;

namespace FamilyMoneyManagerApp.Models
{
    public class ShoppingCart
    {
        public int Id { get; set; }

        public virtual ICollection<ShoppingCartItems> Items { get; set; }

        public int TotalNumberOfItems { get; set; }

        public decimal TotalPrice { get; set; }
    }
}