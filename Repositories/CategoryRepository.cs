using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FamilyMoneyManagerApp.Context;
using FamilyMoneyManagerApp.Models;

namespace FamilyMoneyManagerApp.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly FamilyMoneyManagerContext _context;

        public CategoryRepository(FamilyMoneyManagerContext context)
        {
            _context = context;
        }

        public Category Create(Category category)
        {
            _context.Add(category);
            _context.SaveChanges();
            return category;
        }

        public Category Get(int id)
        {
            var category = _context.Categories.FirstOrDefault(c => c.Id == id);
            if (category == null)
                return null;
            return category;
        }

        public IEnumerable<Category> Get()
        {
            var categories = _context.Categories.ToList();
            return categories;
        }

        public void Remove(int id)
        {
            var category = _context.Categories.FirstOrDefault(c => c.Id == id);
            if (category != null)
            {
                _context.Categories.Remove(category);
                _context.SaveChanges();
            }
        }

        public Category Update(Category category)
        {
            var cat = _context.Categories.FirstOrDefault(c => c.Id == category.Id);

            if (cat == null)
                return null;

            _context.Categories.Update(category);
            _context.SaveChanges();
            return category;
        }
    }
}
