using System;
using System.Collections.Generic;
using System.Text;
using GraphStudy.Menu.Models;

namespace GraphStudy.Menu.Service
{
    public interface IMealService
    {
        /// <summary>
        /// 取得所有餐點
        /// </summary>
        /// <returns></returns>
        List<Meal> GetAllMeals();
        /// <summary>
        /// 按照編號搜尋餐點
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Meal GetMealById(int id);
    }
}
