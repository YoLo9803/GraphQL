using GraphQL.Types;
using GraphStudy.Menu.Models;

namespace GraphStudy.Menu.Schema
{
    public class DrinksType : ObjectGraphType<Drinks>
    {
        public DrinksType()
        {
            //配料編號
            Field(context => context.id);
            //配料名稱
            Field(context => context.name);
        }
    }
}
