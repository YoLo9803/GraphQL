using GraphQL.Types;
using GraphStudy.Menu.Models;
using GraphStudy.Menu.Service;

namespace GraphStudy.Menu.Schema
{
    public class MealType : ObjectGraphType<Meal>
    {
        public MealType(IDessertService dessertService)
        {
            //餐點編號
            Field(context => context.id);
            //餐點名稱
            Field(context => context.name);
            //搭配飲料的編號
            Field(context => context.dessertId);
            //搭配的飲料
            Field<DessertType>("dessert", resolve: 
                context => dessertService.GetDessertById(context.Source.dessertId));
        }
    }
}
