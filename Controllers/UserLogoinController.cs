using FamilyMoneyManagerApp.Interfaces;
using FamilyMoneyManagerApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FamilyMoneyManagerApp.Controllers
{
    [Route("api/usersLogin")]
    [ApiController]
    public class UserLogoinController : Controller
    {
        private readonly IUserService _userService;

        public UserLogoinController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public ActionResult<User> Login(UserLogin userLogin)
        {
            var user = _userService.Login(userLogin);
            if (user == null)
                return null;
            return Ok(user);
        }

    }
}
