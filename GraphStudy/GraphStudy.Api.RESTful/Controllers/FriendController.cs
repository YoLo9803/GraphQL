using Microsoft.AspNetCore.Mvc;
using GraphStudy.Services;
using GraphStudy.Models;
using System.Collections.Generic;

namespace GraphStudy.Api.RESTful.Controllers
{
    [ApiController]
    public class FriendController : ControllerBase
    {
        IFriendService friendService;
        public FriendController(IFriendService friendService)
        {
            this.friendService = friendService;
        }

        //GET {port}/api/Friend/{userId}
        [HttpGet]
        [Route("api/[controller]/{userId}")]
        public ActionResult<List<Friend>> GetFriendById(int userId)
        {
            return friendService.GetFriendsById(userId);
        }
    }
}