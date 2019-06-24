using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GraphStudy.Menu.Models;

namespace GraphStudy.Menu.Service
{
    public class DrinksService : IDrinksService
    {
        private readonly List<Drinks> allDrinks;

        public DrinksService()
        {
            allDrinks = new List<Drinks>
            {
                #region 配料列表
                new Drinks
                {
                    id = 1,
                    name = "蘋果醋"
                },
                new Drinks
                {
                    id = 2,
                    name = "伯爵紅茶"
                },
                new Drinks
                {
                    id = 3,
                    name = "英倫奶茶"
                },
                new Drinks
                {
                    id = 4,
                    name = "榛果牛奶"
                },
                new Drinks
                {
                    id = 5,
                    name = "草莓牛奶"
                }
                #endregion
            };
        }

        /// <summary>
        /// 按照編號搜尋餐點
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Drinks GetDrinksById(int id)
        {
            Drinks drinks = allDrinks.SingleOrDefault(context => context.id == id);
            if (drinks == null)
            {
                throw new ArgumentException(String.Format("Meal ID {0} 不正確", id));
            }
            return drinks;
        }
    }
}
