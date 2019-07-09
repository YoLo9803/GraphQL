using System;
using System.Collections.Generic;
using System.Text;
using GraphStudy.Menu.Models;

namespace GraphStudy.Menu.Service
{
    public interface IBeverageService
    {
        /// <summary>
        /// 取得所有飲料
        /// </summary>
        /// <returns></returns>
        List<Beverage> GetAllBeverages();
        /// <summary>
        /// 按照編號搜尋配料
        /// </summary>
        Beverage GetBeverageById(int id);
        
    }
}
