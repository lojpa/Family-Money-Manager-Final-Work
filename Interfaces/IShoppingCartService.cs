using FamilyMoneyManagerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyMoneyManagerApp.Interfaces
{
    public interface IShoppingCartService
    {
        ShoppingCart Get(int id);
        IEnumerable<ShoppingCart> Get();
        ShoppingCart Create(ShoppingCart item);
    }
}
