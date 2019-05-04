using FamilyMoneyManagerApp.Interfaces;
using FamilyMoneyManagerApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyMoneyManagerApp.Controllers
{
    [Route("api/items")]
    [ApiController]
    public class ItemController: Controller
    {
        private readonly IItemService _itemService;

        public ItemController(IItemService itemService)
        {
            _itemService = itemService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Item>> Get()
        {
            var items = _itemService.Get();
            return Ok(items);
        }

        [HttpGet("{id}")]
        public ActionResult<Item> Get(int id)
        {
            var item = _itemService.Get(id);
            if (item == null)
                return NotFound();
            return Ok(item);
        }

        [HttpPost]
        public ActionResult<Item> Create(Item item)
        {
            var createdItem = _itemService.Create(item);
            return Ok(createdItem);
        }
    }
}
