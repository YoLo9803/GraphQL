using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GraphStudy.Models;
using GraphStudy.Services;

namespace GraphStudy.Api.RESTful.Controllers
{
    [ApiController]
    public class UserController : ControllerBase
    {
        IUserService userService;

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="userService"></param>
        public UserController(IUserService userService)
        {
            //DI
            this.userService = userService;
        }
        /// <summary>
        /// 按照ID取得使用者
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/[controller]/{userId}")]
        public ActionResult<User> GetUserById(int userId)
        {
            return userService.GetUserById(userId);
        }
    }
}