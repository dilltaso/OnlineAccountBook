using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineAccountBook.Models
{
    [Table("AccountBook")]
    public class AccountBookDBTable
    {
        public Guid Id { get; set; }

        public int Categoryyy { get; set; }

        public int Amounttt { get; set; }

        public DateTime Dateee { get; set; }

        [Required]
        [StringLength(500)]
        public string Remarkkk { get; set; }
    }
}