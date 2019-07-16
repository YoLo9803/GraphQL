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
    [Route("api/[controller]")]
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
        [HttpGet("{id}")]
        public ActionResult<User> Get(int id)
        {
            return userService.GetUserById(id);
        }
    }
}