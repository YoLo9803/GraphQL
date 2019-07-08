using GraphQL.Types;
using GraphStudy.Menu.Service;
using GraphQL.Instrumentation;

namespace GraphStudy.Menu.Schema
{
    public class MenuQuery : ObjectGraphType
    {
        //Query的ObjectType
        public MenuQuery(IMealService mealService, IDrinksService drinksService)
        {
            //查詢所有餐點
            Field<ListGraphType<MealType>>("meal", 
                resolve: context => mealService.GetAllMeals());

            Field<ListGraphType<DrinksType>> ("drink",
                resolve: context => drinksService.GetAllDrinks());

        }
    }
}
