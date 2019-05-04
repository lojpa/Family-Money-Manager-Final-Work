using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FamilyMoneyManagerApp.Models;
using FamilyMoneyManagerApp.Repositories;
using FamilyMoneyManagerApp.Interfaces;


namespace FamilyMoneyManagerApp.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public Category Create(Category category)
        {
            var createdCategory = _categoryRepository.Create(category);
            return createdCategory;
        }

        public Category Get(int id)
        {
            var category = _categoryRepository.Get(id);
            return category;
        }

        public IEnumerable<Category> Get()
        {
            var categories = _categoryRepository.Get();
            return categories;
        }

        public void Remove(int id)
        {
            _categoryRepository.Remove(id);
        }

        public Category Update(Category category)
        {
            var updatedCategory = _categoryRepository.Update(category);
            return updatedCategory;
        }
    }
}
