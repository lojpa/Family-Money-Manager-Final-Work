using FamilyMoneyManagerApp.Models;
using FamilyMoneyManagerApp.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyMoneyManagerApp.Controllers
{
    [Route("api/categories")]
    [ApiController]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Category>> Get()
        {
            var categories = _categoryService.Get();
            return Ok(categories);
        }

        [HttpGet("{id}")]
        public ActionResult<Category> Get(int id)
        {
            var category = _categoryService.Get(id);
            if (category == null)
                return NotFound();
            return Ok(category);
        }

        [HttpPost]
        public ActionResult<Category> Create(Category category)
        {
            var createdCategory = _categoryService.Create(category);
            return Ok(createdCategory);
        }

        [HttpDelete("{id}")]
        public ActionResult Remove(int id)
        {
            _categoryService.Remove(id);
            return NoContent();
        }

        [HttpPut]
        public ActionResult<Category> Update(Category categoryVM)
        {
            throw new NotImplementedException();
        }

    }
}
