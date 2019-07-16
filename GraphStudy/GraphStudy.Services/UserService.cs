using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GraphStudy.Models;

namespace GraphStudy.Services
{
    /// <summary>
    /// 使用者Service
    /// </summary>
    public class UserService : IUserService
    {
        readonly List<User> users;

        public UserService()
        {
            users = new List<User> {
                new User{
                    Id = 1,
                    Name = "chris",
                    FriendIds = new List<int>{2,3,4}
                },
                new User{
                    Id = 2,
                    Name = "kenny",
                    FriendIds = new List<int>{1,3,4}
                },
                new User{
                    Id = 3,
                    Name = "marty",
                    FriendIds = new List<int>{1,2}
                },
                new User{
                    Id = 4,
                    Name = "shia",
                    FriendIds = new List<int>{1,2,3}
                }
            };
        }
        /// <summary>
        /// 按照ID取得使用者
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public User GetUserById(int id)
        {
            User selectedUser = users.SingleOrDefault(context => context.Id == id);
            if (selectedUser == null)
            {
                throw new ArgumentException(String.Format("User ID {0} 不存在", id));
            }
            return selectedUser;
        }
    }
}
