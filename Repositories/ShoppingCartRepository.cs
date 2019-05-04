using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FamilyMoneyManagerApp.Context;
using FamilyMoneyManagerApp.Models;

namespace FamilyMoneyManagerApp.Repositories
{
    public class ShoppingCartRepository : IShoppingCartRepository
    {
        private readonly FamilyMoneyManagerContext _context;

        public ShoppingCartRepository(FamilyMoneyManagerContext context)
        {
            _context = context;
        }

        public ShoppingCart Create(ShoppingCart shoppingCart)
        {
            _context.Add<ShoppingCart>(shoppingCart);
            _context.SaveChanges();
            return shoppingCart;
        }

        public ShoppingCart Get(int id)
        {
            return _context.ShoppingCarts.Where(x => x.Id == id).FirstOrDefault();
        }

        public IEnumerable<ShoppingCart> Get()
        {
            return _context.ShoppingCarts.ToList();
        }
    }
}
