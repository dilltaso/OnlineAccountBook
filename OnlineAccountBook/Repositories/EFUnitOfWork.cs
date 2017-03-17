using OnlineAccountBook.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OnlineAccountBook.Repositories
{
    //資料庫物件
    public class EFUnitOfWork : IUnitOfWork
    {
        public DbContext Context { get; set; }        

        public EFUnitOfWork()
        {
            Context = new AccountBookDBEntities();
        }

        public void Save()
        {
            Context.SaveChanges();
        }

        public void Dispose()
        {
            Context.Dispose();
        }
    }
}