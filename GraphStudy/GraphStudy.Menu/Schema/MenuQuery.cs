using GraphQL.Types;
using GraphStudy.Menu.Service;
using GraphQL.Instrumentation;

namespace GraphStudy.Menu.Schema
{
    /// <summary>
    /// Menu的ObjectType
    /// </summary>
    public class MenuQuery : ObjectGraphType
    {
        //Query的ObjectType
        public MenuQuery(IMealService mealService, IBeverageService beverageService)
        {
            //查詢所有餐點
            Field<ListGraphType<MealType>>("meal", 
                resolve: context => mealService.GetAllMeals());
            //查詢所有飲料
            Field<ListGraphType<BeverageType>> ("drink",
                resolve: context => beverageService.GetAllBeverages());

        }
    }
}
