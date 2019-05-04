using FamilyMoneyManagerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyMoneyManagerApp.Repositories
{
    public interface ICategoryRepository
    {
        Category Get(int id);
        IEnumerable<Category> Get();
        Category Create(Category category);
        Category Update(Category category);
        void Remove(int id);
    }
}
