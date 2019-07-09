using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GraphStudy.Menu.Models;

namespace GraphStudy.Menu.Service
{
    public class DessertService : IDessertService
    {
        List<Dessert> allDessert;
        public DessertService()
        {
            allDessert = new List<Dessert>
            {
                #region 點心初始化
                new Dessert
                {
                    id = 1,
                    name = "鮮奶酪"
                },
                new Dessert
                {
                    id = 2,
                    name = "霜淇淋"
                },
                new Dessert
                {
                    id = 3,
                    name = "馬卡龍"
                },
                new Dessert
                {
                    id = 4,
                    name = "山羊起司"
                },
                new Dessert
                {
                    id = 5,
                    name = "蛋捲冰淇淋"
                }
                #endregion
            };
        }

        /// <summary>
        /// 按照編號尋找點心
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Dessert GetDessertById(int id)
        {
            Dessert selectedDessert = allDessert.SingleOrDefault(context => context.id == id);
            if (selectedDessert == null)
            {
                throw new ArgumentException(String.Format("Dessert ID {0} 不正確", id));
            }
            return selectedDessert;
        }
    }
}
