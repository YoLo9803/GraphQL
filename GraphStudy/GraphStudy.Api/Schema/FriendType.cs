using GraphQL.Types;
using GraphStudy.Models;
using GraphStudy.Services;

namespace GraphStudy.Api.Schema
{
    public class FriendType : ObjectGraphType<Friend>
    {
        public FriendType(IUserService userService)
        {
            Field<UserType>("user", resolve:
                context => userService.GetUserById(context.Source.FriendId));
            Field(context => context.CreateDate);
        }
    }
}
