using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineAccountBook.Models.ViewModels
{
    public class AccountItemViewModel
    {
        /// <summary>
        /// 類別
        /// </summary>
        public string Category { get; set; }
        /// <summary>
        /// 日期
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// 金額
        /// </summary>
        public double Money { get; set; }
        /// <summary>
        /// 備註
        /// </summary>
        public string Description { get; set; }
    }
}