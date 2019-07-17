using System.Collections.Generic;
using GraphStudy.Models;

namespace GraphStudy.Services
{
    public interface IFriendService
    {
        /// <summary>
        /// 按照使用者編號尋找朋友
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        List<Friend> GetFriendsById(int userId);
    }
}