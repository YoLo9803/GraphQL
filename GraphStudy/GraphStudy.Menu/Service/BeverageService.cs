using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GraphStudy.Menu.Models;

namespace GraphStudy.Menu.Service
{
    public class BeverageService : IBeverageService
    {
        private readonly List<Beverage> allBeverages;

        public BeverageService()
        {
            allBeverages = new List<Beverage>
            {
                #region 配料列表
                new Beverage
                {
                    id = 1,
                    name = "檸檬汁"
                },
                new Beverage
                {
                    id = 2,
                    name = "冰淇淋紅茶"
                },
                new Beverage
                {
                    id = 3,
                    name = "咖啡拿鐵"
                },
                new Beverage
                {
                    id = 4,
                    name = "蘋果醋"
                },
                new Beverage
                {
                    id = 5,
                    name = "伯爵紅茶"
                },
                new Beverage
                {
                    id = 6,
                    name = "英倫奶茶"
                },
                new Beverage
                {
                    id = 7,
                    name = "榛果牛奶"
                },
                new Beverage
                {
                    id = 8,
                    name = "草莓牛奶"
                }
                #endregion
            };
        }
        /// <summary>
        /// 取得所有飲料
        /// </summary>
        public List<Beverage> GetAllBeverages()
        {
            return allBeverages;
        }

        /// <summary>
        /// 按照編號搜尋餐點
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Beverage GetBeverageById(int id)
        {
            Beverage beverage = allBeverages.SingleOrDefault(context => context.id == id);
            if (beverage == null)
            {
                throw new ArgumentException(String.Format("Meal ID {0} 不正確", id));
            }
            return beverage;
        }
    }
}
