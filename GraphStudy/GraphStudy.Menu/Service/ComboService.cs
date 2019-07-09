using System;
using System.Collections.Generic;
using System.Text;
using GraphStudy.Menu.Models;

namespace GraphStudy.Menu.Service
{
    public class ComboService : IComboService
    {
        List<Combo> allCombos;
        public ComboService()
        {
            allCombos = new List<Combo>
            {
                #region 套餐初始化
                new Combo
                {
                    id = 1,
                    name = "套餐一",
                    mealId = 1,
                    beverageId = 1
                },
                new Combo
                {
                    id = 2,
                    name = "套餐二",
                    mealId = 3,
                    beverageId = 3
                },
                new Combo
                {
                    id = 3,
                    name = "套餐三",
                    mealId = 4,
                    beverageId = 5
                }
                #endregion
            };
        }
        /// <summary>
        /// 取得所有套餐
        /// </summary>
        /// <returns></returns>
        public List<Combo> GetAllCombos()
        {
            return allCombos;
        }
    }
}
