using GraphQL.Types;
using GraphStudy.Menu.Models;

namespace GraphStudy.Menu.Schema
{
    /// <summary>
    /// 飲料ObjectType
    /// </summary>
    public class BeverageType : ObjectGraphType<Beverage>
    {
        public BeverageType()
        {
            //飲料編號
            Field(context => context.id);
            //飲料名稱
            Field(context => context.name);
        }
    }
}
