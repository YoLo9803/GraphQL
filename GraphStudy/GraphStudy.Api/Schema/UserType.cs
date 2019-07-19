using GraphQL.Types;
using GraphStudy.Models;
using GraphStudy.Services;
using System.Collections.Generic;

namespace GraphStudy.Api.Schema
{
    public class UserType : ObjectGraphType<User>
    {
        public UserType(IUserService userService)
        {
            //使用者編號
            Field(context => context.Id);
            //使用者名稱
            Field(context => context.Name);
            //朋友
            Field<ListGraphType<UserType>>
            (
                "friend",
                resolve: context => 
                {
                    List<User> friendList = new List<User>();
                    foreach (int friendId in context.Source.FriendIds)
                    {
                        friendList.Add(userService.GetUserById(friendId));
                    }
                    return friendList;
                }
            );
        }
    }
}
