using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GraphStudy.Menu.Models;

namespace GraphStudy.Menu.Service
{
    public class MealService : IMealService
    {
        private readonly List<Meal> allMeals;
        public MealService()
        {
            allMeals = new List<Meal>
            {
                #region 餐點列表
                new Meal
                {
                    id = 1,
                    name = "炸豬排飯",
                    dessertId = 1
                },
                new Meal
                {
                    id = 2,
                    name = "綠咖哩飯",
                    dessertId = 2
                },
                new Meal
                {
                    id = 3,
                    name = "肉醬義大利麵",
                    dessertId = 3
                },
                new Meal
                {
                    id = 4,
                    name = "法式酸奶佐鄉村麵包",
                    dessertId = 4
                },
                new Meal
                {
                    id = 5,
                    name = "快樂兒童餐",
                    dessertId = 5
                } 
                #endregion
            };
        }
        /// <summary>
        /// 取得所有餐點
        /// </summary>
        /// <returns></returns>
        public List<Meal> GetAllMeals()
        {
            return allMeals;
        }
        /// <summary>
        /// 按照編號搜尋餐點
        /// </summary>
        /// <returns></returns>
        public Meal GetMealById(int id)
        {
            Meal meal = allMeals.SingleOrDefault(context => context.id == id);
            if (meal == null)
            {
                throw new ArgumentException(String.Format("Meal ID {0} 不正確", id));
            }
            return meal;
        }
    }
}
