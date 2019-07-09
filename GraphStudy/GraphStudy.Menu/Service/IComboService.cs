using System.Collections.Generic;
using GraphStudy.Menu.Models;

namespace GraphStudy.Menu.Service
{
    public interface IComboService
    {
        /// <summary>
        /// 取得所有套餐
        /// </summary>
        /// <returns></returns>
        List<Combo> GetAllCombos();
    }
}