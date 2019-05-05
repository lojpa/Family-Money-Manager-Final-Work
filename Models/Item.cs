using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyMoneyManagerApp.Models
{
    public enum ItemType
    {
        DrinkFood = 1,
        Clothes,
        Equipment
    }

    public class Item
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ItemType ItemType { get; set; }

        public decimal Price { get; set; }

        public string ImageUrl { get; set; }

        public List<ItemCart> ItemCarts { get; set; }
    }
}
