using GraphQL.Types;
using GraphStudy.Menu.Service;
using GraphQL.Instrumentation;

namespace GraphStudy.Menu.Schema
{
    public class MenuQuery : ObjectGraphType
    {
        //Query的ObjectType
        public MenuQuery(IMealService mealService)
        {
            //查詢所有餐點
            Field<ListGraphType<MealType>>("allMeals", 
                resolve: context => mealService.GetAllMeals());

            Field<MealType>("set", resolve: context => mealService.GetMealById(1));
        }
    }
}
