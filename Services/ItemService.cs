using FamilyMoneyManagerApp.Interfaces;
using FamilyMoneyManagerApp.Models;
using FamilyMoneyManagerApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyMoneyManagerApp.Services
{
    public class ItemService : IItemService
    {

        private readonly IItemRepository _repository;

        public ItemService(IItemRepository repository)
        {
            _repository = repository;
        }


        public Item Create(Item item)
        {
            _repository.Create(item);
            return item;
        }

        public Item Get(int id)
        {
            return _repository.Get(id);
        }

        public IEnumerable<Item> Get()
        {
            return _repository.Get();
        }
    }
}
