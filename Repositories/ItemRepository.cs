using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FamilyMoneyManagerApp.Context;
using FamilyMoneyManagerApp.Models;

namespace FamilyMoneyManagerApp.Repositories
{
    public class ItemRepository : IItemRepository
    {
        private readonly FamilyMoneyManagerContext _context;

        public ItemRepository(FamilyMoneyManagerContext context)
        {
            _context = context;
        }

        public Item Create(Item item)
        {
            _context.Add<Item>(item);
            _context.SaveChanges();
            return item;
        }

        public Item Get(int id)
        {
            return _context.Items.Where(x => x.Id == id).FirstOrDefault();
        }

        public IEnumerable<Item> Get()
        {
            return _context.Items.ToList();
        }
    }
}
