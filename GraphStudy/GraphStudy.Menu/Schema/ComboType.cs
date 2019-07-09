using System;
using System.Collections.Generic;
using System.Text;
using GraphQL.Types;
using GraphStudy.Menu.Models;
using GraphStudy.Menu.Service;

namespace GraphStudy.Menu.Schema
{
    /// <summary>
    /// 套餐ObjectType
    /// </summary>
    public class ComboType : ObjectGraphType<Combo>
    {
        public ComboType(IMealService mealService, IBeverageService beverageService)
        {
            //套餐編號
            Field(context => context.id);
            //套餐名稱
            Field(context => context.name);
            //套餐搭配餐點編號
            Field(context => context.mealId);
            //套餐搭配飲料編號
            Field(context => context.beverageId);
            //套餐搭配餐點
            Field<MealType>("meal", resolve:
                context => mealService.GetMealById(context.Source.mealId));
            //套餐搭配飲料
            Field<BeverageType>("beverage", resolve:
                context => beverageService.GetBeverageById(context.Source.beverageId));
        }
    }
}
