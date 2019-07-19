using System;
using System.Collections.Generic;
using System.Text;
using GraphStudy.Models;
using System.Linq;

namespace GraphStudy.Services
{
    public class FriendService : IFriendService
    {
        List<Friend> friendList;
        public FriendService()
        {
            friendList = new List<Friend>
            {
                new Friend
                {
                    UserId = 1,
                    FriendId = 2,
                    CreateDate = new DateTime(2019,3,23)
                },
                new Friend
                {
                    UserId = 1,
                    FriendId = 4,
                    CreateDate = new DateTime(2016,3,2)
                },
                new Friend
                {
                    UserId = 1,
                    FriendId = 5,
                    CreateDate = new DateTime(2018,6,3)
                },
                new Friend
                {
                    UserId = 1,
                    FriendId = 6,
                    CreateDate = new DateTime(2019,4,9)
                },
                new Friend
                {
                    UserId = 2,
                    FriendId = 1,
                    CreateDate = new DateTime(2019,3,23)
                },
                new Friend
                {
                    UserId = 2,
                    FriendId = 3,
                    CreateDate = new DateTime(2009,7,21)
                },
                new Friend
                {
                    UserId = 2,
                    FriendId = 4,
                    CreateDate = new DateTime(2019,4,17)
                },
                new Friend
                {
                    UserId = 3,
                    FriendId = 2,
                    CreateDate = new DateTime(2019,4,2)
                },
                new Friend
                {
                    UserId = 3,
                    FriendId = 4,
                    CreateDate = new DateTime(2009,7,21)
                },
                new Friend
                {
                    UserId = 4,
                    FriendId = 1,
                    CreateDate = new DateTime(2019,4,2)
                },
                new Friend
                {
                    UserId = 4,
                    FriendId = 2,
                    CreateDate = new DateTime(2019,4,2)
                },
                new Friend
                {
                    UserId = 4,
                    FriendId = 3,
                    CreateDate = new DateTime(2012,12,6)
                },
                new Friend
                {
                    UserId = 5,
                    FriendId = 1,
                    CreateDate = new DateTime(2018,6,3)
                },
                new Friend
                {
                    UserId = 6,
                    FriendId = 1,
                    CreateDate = new DateTime(2019,4,9)
                }
            };
        }

        /// <summary>
        /// 按照使用者編號取得朋友
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public List<Friend> GetFriendsById(int userId)
        {
            return friendList.Where(item => item.UserId == userId).ToList();
        }
    }
}
