using FamilyMoneyManagerApp.Interfaces;
using FamilyMoneyManagerApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyMoneyManagerApp.Controllers
{
    [Route("api/shoppingCarts")]
    [ApiController]
    public class ShoppingCartController : Controller
    {
        private readonly IShoppingCartService _shoppingCartService;

        public ShoppingCartController(IShoppingCartService shoppingCartService)
        {
            _shoppingCartService = shoppingCartService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ShoppingCart>> Get()
        {
            var items = _shoppingCartService.Get();
            return Ok(items);
        }

        [HttpGet("{id}")]
        public ActionResult<ShoppingCart> Get(int id)
        {
            var item = _shoppingCartService.Get(id);
            if (item == null)
                return NotFound();
            return Ok(item);
        }

        [HttpPost]
        public ActionResult<ShoppingCart> Create(ShoppingCart shoppingCart)
        {
            var createdShoppingCart = _shoppingCartService.Create(shoppingCart);
            return Ok(createdShoppingCart);
        }
    }
}
