using FamilyMoneyManagerApp.Interfaces;
using FamilyMoneyManagerApp.Models;
using FamilyMoneyManagerApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyMoneyManagerApp.Services
{
    public class ShoppingCartService : IShoppingCartService
    {

        private readonly IShoppingCartRepository _repository;

        public ShoppingCartService(IShoppingCartRepository repository)
        {
            _repository = repository;
        }


        public ShoppingCart Create(ShoppingCart shoppingCart)
        {
            _repository.Create(shoppingCart);
            return shoppingCart;
        }

        public ShoppingCart Get(int id)
        {
            return _repository.Get(id);
        }

        public IEnumerable<ShoppingCart> Get()
        {
            return _repository.Get();
        }
    }
}
