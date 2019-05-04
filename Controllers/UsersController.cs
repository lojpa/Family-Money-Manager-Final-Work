using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FamilyMoneyManagerApp.Interfaces;
using FamilyMoneyManagerApp.Models;
using FamilyMoneyManagerApp.Repositories;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FamilyMoneyManagerApp.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : Controller
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("{id}")]
        public ActionResult<User> Get(int id)
        {
            var user = _userService.Get(id);
            if (user == null)
                return NotFound();
            return Ok(user);
        }

        [HttpPost]
        public ActionResult<User> Create(User user)
        {
            var createdUser = _userService.Create(user);
            if (createdUser == null)
                return BadRequest();
            return Ok(createdUser);
        }
    }
}