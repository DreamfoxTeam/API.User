using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project.API.User.Business.Interface;
using Project.API.User.Business.Messages.Requests;

namespace Project.API.User.WebApi.Controllers
{
    /// <summary>
    /// This class counts the user APIs
    /// </summary>
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        readonly IUserService _userService;

        /// <summary>
        /// Instance the object of the user business
        /// </summary>
        /// <param name="userService"></param>
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        /// <summary>
        /// Register a new user on system
        /// </summary>
        /// <param name="request"></param>
        /// <returns>Return an object with status of request</returns>
        [HttpPost]
        public async Task<IActionResult> Register([FromBody]UserRequest request)
        {
            return Ok(await Task.Run(() => _userService.Save(request)));
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "User 1", "User 2" };
        }

        [HttpGet]
        [Route("{userId}")]
        public string Get(long userId)
        {
            return _userService.GetUser(userId);
        }
    }
}
