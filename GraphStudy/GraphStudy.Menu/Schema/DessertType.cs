using GraphQL.Types;
using GraphStudy.Menu.Models;

namespace GraphStudy.Menu.Schema
{
    public class DessertType : ObjectGraphType<Dessert>
    {
        public DessertType()
        {
            //點心編號
            Field(context => context.id);
            //點心名稱
            Field(context => context.name);
        }
    }
}
