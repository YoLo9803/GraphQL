using System;

namespace GraphStudy.Models
{
    public class Friend
    {
        /// <summary>
        /// 使用者編號
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// 朋友編號
        /// </summary>
        public int FriendId { get; set; }
        /// <summary>
        /// 建立時間
        /// </summary>
        public DateTime CreateDate { get; set; }
    }
}
