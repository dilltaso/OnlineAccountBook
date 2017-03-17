using OnlineAccountBook.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace OnlineAccountBook.Models
{
    public class AccountBookDBEntities : DbContext
    {
        public AccountBookDBEntities()
            : base("name=AccountBookDBEntities")
        {

        }

        //public virtual DbSet<AccountItemViewModels> AccountBook { get; set; }  //無索引鍵
        public virtual DbSet<AccountBookDBTable> AccountBook { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
        }
    }
}