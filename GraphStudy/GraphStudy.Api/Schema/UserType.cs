using GraphQL.Types;
using GraphStudy.Models;
using GraphStudy.Services;
using System.Collections.Generic;

namespace GraphStudy.Api.Schema
{
    public class UserType : ObjectGraphType<User>
    {
        public UserType(IUserService userService,IFriendService friendService)
        {
            //使用者編號
            Field(context => context.Id);
            //使用者名稱
            Field(context => context.Name);
            //朋友
            Field<ListGraphType<FriendType>>("friend", resolve:
                context => friendService.GetFriendsById(context.Source.Id));
        }
    }
}
