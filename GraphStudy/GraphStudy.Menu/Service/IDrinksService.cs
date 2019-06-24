using System;
using System.Collections.Generic;
using System.Text;
using GraphStudy.Menu.Models;

namespace GraphStudy.Menu.Service
{
    public interface IDrinksService
    {
        /// <summary>
        /// 按照編號搜尋配料
        /// </summary>
        Drinks GetDrinksById(int id);
    }
}
