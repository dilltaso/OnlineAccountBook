using OnlineAccountBook.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [CheckDateValid(ErrorMessage = "日期不可大於今天!")]
        public DateTime Date { get; set; }
        
        /// <summary>
        /// 金額
        /// </summary>
        [Range(0, Int32.MaxValue, ErrorMessage = "只能輸入正整數!")]
        public double Money { get; set; }
        
        /// <summary>
        /// 備註
        /// </summary>
        [StringLength(100, ErrorMessage = "最多輸入100個字元!")]
        public string Description { get; set; }
    }
}