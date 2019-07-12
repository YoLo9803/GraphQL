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
            users = new List<User>();
        }
        public User GetUserById(int id)
        {
            User selectedUser = users.SingleOrDefault(context => context.Id == id);
            if (selectedUser == null)
            {
                throw new ArgumentException(String.Format("User ID {0} 不存在", id));
            }
            return null;
        }
    }
}
