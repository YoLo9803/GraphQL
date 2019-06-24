using System;
using System.Collections.Generic;
using System.Text;

namespace GraphStudy.Menu.Models
{
    /// <summary>
    /// 餐點
    /// </summary>
    public class Meal
    {
        /// <summary>
        /// 餐點編號
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 餐點名稱
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 配料編號
        /// </summary>
        public int DrinksId { get; set; }
    }
}
