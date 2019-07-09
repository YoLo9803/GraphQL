using System;
using System.Collections.Generic;
using System.Text;
using GraphStudy.Menu.Models;

namespace GraphStudy.Menu.Models
{
    /// <summary>
    /// 套餐
    /// </summary>
    public class Combo
    {
        /// <summary>
        /// 套餐編號
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 套餐名稱
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 搭配的餐點編號
        /// </summary>
        public int mealId { get; set; }
        /// <summary>
        /// 搭配的飲料編號
        /// </summary>
        public int beverageId { get; set; }
    }
}
