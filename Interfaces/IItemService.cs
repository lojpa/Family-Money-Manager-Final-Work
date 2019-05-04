using FamilyMoneyManagerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyMoneyManagerApp.Interfaces
{
    public interface IItemService
    {
        Item Get(int id);
        IEnumerable<Item> Get();
        Item Create(Item item);
    }
}
