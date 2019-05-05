using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyMoneyManagerApp.Models
{
    public class ItemCart
    {
        public int Id { get; set; }

        public int Counter { get; set; }

        public int ItemId { get; set; }

        [ForeignKey("ItemId")]
        public Item Item { get; set; }

        public int ShoppingCartId { get; set; }

        [ForeignKey("ShoppingCartId")]
        public ShoppingCart ShoppingCart { get; set; }


    }
}
