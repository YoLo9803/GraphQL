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
            Field<ListGraphType<MealType>>("meals", 
                resolve: context => mealService.GetAllMeals());

            Field<MealType>("set", resolve: context => mealService.GetMealById(1));

            Field<ListGraphType<DrinksType>> ("drinks",
                resolve: context => drinksService.GetAllDrinks());
        }
    }
}
