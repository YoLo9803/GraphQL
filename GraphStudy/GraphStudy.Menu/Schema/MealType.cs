using GraphQL.Types;
using GraphStudy.Menu.Models;
using GraphStudy.Menu.Service;

namespace GraphStudy.Menu.Schema
{
    public class MealType : ObjectGraphType<Meal>
    {
        public MealType(IDrinksService drinksService)
        {
            //餐點編號
            Field(context => context.id);
            //餐點名稱
            Field(context => context.name);
            //餐點配料
            Field(context => context.DrinksId);
            //搭配的飲料
            Field<DrinksType>("drinks", resolve: 
                context => drinksService.GetDrinksById(context.Source.DrinksId));
        }
    }
}
